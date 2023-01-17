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
    public partial class OgrDersGuncelleFormu : Form
    {
        ProjeConnectionOkulDbEntities db = new ProjeConnectionOkulDbEntities();

        public OgrDersGuncelleFormu()
        {
            InitializeComponent();
        }

        private void OgrDersGuncelleFormu_Load(object sender, EventArgs e)
        {
            DgvOgrDers.DataSource = db.OgrenciDers.ToList();
        }

        private void DgvOgrDers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtDersID.Text = DgvOgrDers.CurrentRow.Cells[1].Value.ToString();
            TxtOgrenciID.Text = DgvOgrDers.CurrentRow.Cells[2].Value.ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(DgvOgrDers.CurrentRow.Cells[0].Value.ToString());

            OgrenciDers ogrdersguncelle = db.OgrenciDers.FirstOrDefault(x => x.ID == id);

            ogrdersguncelle.DersID = int.Parse(TxtDersID.Text);
            ogrdersguncelle.OgrenciID = int.Parse(TxtOgrenciID.Text);

            DialogResult sor = MessageBox.Show($@"{ogrdersguncelle.DersID} Dersini Güncellemek İstediğinize Emin Misniz?", "UYARI", MessageBoxButtons.YesNo);
            if (sor == DialogResult.Yes)
            {
                db.SaveChanges();
                DgvOgrDers.DataSource = db.OgrenciDers.ToList();

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