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
    public partial class DersGuncelleFormu : Form
    {
        ProjeConnectionOkulDbEntities db = new ProjeConnectionOkulDbEntities();

        public DersGuncelleFormu()
        {
            InitializeComponent();
        }

        private void DersGuncelleFormu_Load(object sender, EventArgs e)
        {
            DgvDers.DataSource = db.Ders.ToList();
        }

        private void DgvDers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtAd.Text = DgvDers.CurrentRow.Cells[1].Value.ToString();
            TxtKredi.Text = DgvDers.CurrentRow.Cells[2].Value.ToString();
            TxtYonetim.Text = DgvDers.CurrentRow.Cells[3].Value.ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(DgvDers.CurrentRow.Cells[0].Value.ToString());

            Ders dersguncelle = db.Ders.FirstOrDefault(x => x.DersID == id);

            dersguncelle.DersAdi = TxtAd.Text;
            dersguncelle.DersKredisi = int.Parse(TxtKredi.Text);
            dersguncelle.OkulYonetimID = int.Parse(TxtYonetim.Text);

            DialogResult sor = MessageBox.Show($@"{dersguncelle.DersAdi} Dersini Güncellemek İstiyor Musunuz?", "UYARI", MessageBoxButtons.YesNo);
            if (sor==DialogResult.Yes)
            {
                db.SaveChanges();
                DgvDers.DataSource = db.Ders.ToList();

                MessageBox.Show("Güncelleme Başarılı");
            }
            else
            {
                MessageBox.Show("Güncelleme İşlemi İptal Edildi!");
            }
        }
    }
}