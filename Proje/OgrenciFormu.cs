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
    public partial class OgrenciFormu : Form
    {
        ProjeConnectionOkulDbEntities db = new ProjeConnectionOkulDbEntities();

        public OgrenciFormu()
        {
            InitializeComponent();
        }

        private void OgrenciFormu_Load(object sender, EventArgs e)
        {
            dgvOgrenci.DataSource = db.Ogrenci.ToList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvOgrenci.CurrentRow.Cells[0].Value.ToString());

            Ogrenci sil = db.Ogrenci.FirstOrDefault(x => x.OgrenciID == id);

            DialogResult sor = MessageBox.Show($@"{sil.OgrenciAdiSoyadi} Öğrencisi Silinecek. Öğrenciyi Sİlmek İstediğinize Emin Misiniz?", "UYARI", MessageBoxButtons.YesNo);
            if (sor == DialogResult.Yes)
            {
                db.Ogrenci.Remove(sil);
                db.SaveChanges();
                dgvOgrenci.DataSource = db.Ogrenci.ToList();

                MessageBox.Show("Silme İşlemi Başarılı");
            }
            else
            {
                MessageBox.Show("Silme İşleminiz İptal Edildi!");
            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            var ara = from x in db.Ogrenci
                      where x.OgrenciAdiSoyadi.Contains(txtAra.Text) || x.OgrenciBolumu.Contains(txtAra.Text)
                      select new
                      {
                          x.OgrenciID,
                          x.OgrenciAdiSoyadi,
                          x.OgrenciNo,
                          x.OgrenciDogumTarihi,
                          x.OgrenciKayitTarihi,
                          x.OgrenciBolumu
                      };
            dgvOgrenci.DataSource = ara.ToList();
        }
    }
}