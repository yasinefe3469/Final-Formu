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
    public partial class YonetimGuncelleFormu : Form
    {
        ProjeConnectionOkulDbEntities db = new ProjeConnectionOkulDbEntities();

        public YonetimGuncelleFormu()
        {
            InitializeComponent();
        }

        private void YonetimGuncelleFormu_Load(object sender, EventArgs e)
        {
            DgvYonetim.DataSource = db.OkulYonetim.ToList();
        }

        private void DgvYonetim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtAdSoyad.Text = DgvYonetim.CurrentRow.Cells[1].Value.ToString();
            TxtGorev.Text = DgvYonetim.CurrentRow.Cells[2].Value.ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(DgvYonetim.CurrentRow.Cells[0].Value.ToString());

            OkulYonetim yoneticiguncelle = db.OkulYonetim.FirstOrDefault(x => x.OkulYonetimID == id);

            yoneticiguncelle.AdSoyad = TxtAdSoyad.Text;
            yoneticiguncelle.Gorevi = TxtGorev.Text;

            DialogResult sor = MessageBox.Show($@"{yoneticiguncelle.AdSoyad} Yöneticisini Güncellemek İstiyor Musunuz?", "UYARI", MessageBoxButtons.YesNo);
            if (sor == DialogResult.Yes)
            {
                db.SaveChanges();
                DgvYonetim.DataSource = db.OkulYonetim.ToList();

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