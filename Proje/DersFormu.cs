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
    public partial class DersFormu : Form
    {
        ProjeConnectionOkulDbEntities db = new ProjeConnectionOkulDbEntities();

        public DersFormu()
        {
            InitializeComponent();
        }

        private void Ders_Load(object sender, EventArgs e)
        {
            dgvDers.DataSource = db.Ders.ToList();
        }

        private void dgvDers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDers.DataSource = db.Ders.ToList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvDers.CurrentRow.Cells[0].Value.ToString());

            Ders sil = db.Ders.FirstOrDefault(x => x.DersID == id);

            DialogResult sor = MessageBox.Show($@"{sil.DersAdi} Dersini Sileceksiniz. Silmek İstediğinize Emin Misiniz?", "UYARI", MessageBoxButtons.YesNo);
            if (sor == DialogResult.Yes)
            {
                db.Ders.Remove(sil);
                db.SaveChanges();
                dgvDers.DataSource = db.Ders.ToList();

                MessageBox.Show("Silme İşlemi Başarılı");
            }
            else
            {
                MessageBox.Show("Silme İşleminiz İptal Edildi!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var ara = from x in db.Ders
                       where x.DersAdi.Contains(textBox1.Text)
                       select new
                       {
                           x.DersID,
                           x.DersAdi,
                           x.DersKredisi,
                           x.OkulYonetimID
                       };
            dgvDers.DataSource = ara.ToList();
        }
    }
}