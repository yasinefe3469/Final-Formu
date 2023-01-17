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
    public partial class YonetimFormu : Form
    {
        ProjeConnectionOkulDbEntities db = new ProjeConnectionOkulDbEntities();

        public YonetimFormu()
        {
            InitializeComponent();
        }

        private void YonetimFormu_Load(object sender, EventArgs e)
        {
            dataGridViewYonetim.DataSource = db.OkulYonetim.ToList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridViewYonetim.CurrentRow.Cells[0].Value.ToString());

            OkulYonetim sil = db.OkulYonetim.FirstOrDefault(x => x.OkulYonetimID == id);

            DialogResult sor = MessageBox.Show($@"{sil.AdSoyad} Yöneticisini Sileceksiniz. Silmek İstediğinize Emin Misiniz?", "UYARI", MessageBoxButtons.YesNo);
            if (sor == DialogResult.Yes)
            {
                db.OkulYonetim.Remove(sil);
                db.SaveChanges();
                dataGridViewYonetim.DataSource = db.OkulYonetim.ToList();

                MessageBox.Show("Silme İşlemi Başarılı");
            }
            else
            {
                MessageBox.Show("Silme İşleminiz İptal Edildi!");
            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            var ara = from x in db.OkulYonetim
                      where x.AdSoyad.Contains(txtAra.Text) || x.Gorevi.Contains(txtAra.Text)
                      select new
                      {
                          x.OkulYonetimID,
                          x.AdSoyad,
                          x.Gorevi
                      };
            dataGridViewYonetim.DataSource = ara.ToList();
        }
    }
}