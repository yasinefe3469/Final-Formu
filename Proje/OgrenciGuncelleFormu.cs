using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proje.Models;

namespace Proje
{
    public partial class OgrenciGuncelleFormu : Form
    {
        ProjeConnectionOkulDbEntities db = new ProjeConnectionOkulDbEntities();

        public OgrenciGuncelleFormu()
        {
            InitializeComponent();
        }

        private void OgrenciGuncelleFormu_Load(object sender, EventArgs e)
        {
            DgvOgrenci.DataSource = db.Ogrenci.ToList();
        }

        private void DgvOgrenci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtAdSoyad.Text = DgvOgrenci.CurrentRow.Cells[1].Value.ToString();
            TxtNo.Text = DgvOgrenci.CurrentRow.Cells[2].Value.ToString();
            TxtDogumTarihi.Text = DgvOgrenci.CurrentRow.Cells[3].Value.ToString();
            TxtKayitTarihi.Text = DgvOgrenci.CurrentRow.Cells[4].Value.ToString();
            TxtBolumu.Text = DgvOgrenci.CurrentRow.Cells[5].Value.ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(DgvOgrenci.CurrentRow.Cells[0].Value.ToString());

            Ogrenci ogrenciguncelle = db.Ogrenci.FirstOrDefault(x => x.OgrenciID == id);

            ogrenciguncelle.OgrenciAdiSoyadi = TxtAdSoyad.Text;
            ogrenciguncelle.OgrenciNo = int.Parse(TxtNo.Text);
            ogrenciguncelle.OgrenciDogumTarihi = DateTime.Parse(TxtDogumTarihi.Text);
            ogrenciguncelle.OgrenciKayitTarihi = DateTime.Parse(TxtDogumTarihi.Text);
            ogrenciguncelle.OgrenciBolumu = TxtBolumu.Text;

            DialogResult sor = MessageBox.Show($@"{ogrenciguncelle.OgrenciAdiSoyadi} Öğrencisini Güncellemek İstiyor Musunuz?", "UYARI", MessageBoxButtons.YesNo);
            if (sor == DialogResult.Yes)
            {
                db.SaveChanges();
                DgvOgrenci.DataSource = db.Ogrenci.ToList();

                MessageBox.Show("Güncelleme Başarılı");
                foreach(Control item in Controls)
                {
                    if (item is TextBox) item.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Güncelleme İşlemi İptal Edildi!");
            }
        }
    }
}