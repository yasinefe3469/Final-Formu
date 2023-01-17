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
    public partial class OgrDersEkleFormu : Form
    {
        ProjeConnectionOkulDbEntities db = new ProjeConnectionOkulDbEntities();

        public OgrDersEkleFormu()
        {
            InitializeComponent();
        }

        private void OgrDersEkleFormu_Load(object sender, EventArgs e)
        {
            DgvOgrDers.DataSource = db.OgrenciDers.ToList();
        }

        private void DgvOgrDers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtDersID.Text = DgvOgrDers.CurrentRow.Cells[1].Value.ToString();
            TxtOgrenciID.Text = DgvOgrDers.CurrentRow.Cells[2].Value.ToString();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            OgrenciDers ogrdersekle = new OgrenciDers();

            ogrdersekle.DersID = int.Parse(TxtDersID.Text);
            ogrdersekle.OgrenciID = int.Parse(TxtOgrenciID.Text);

            DialogResult sor = MessageBox.Show("Yeni Öğrenci Dersi Eklemek İstiyor Musunuz?", "UYARI", MessageBoxButtons.YesNo);
            if (sor == DialogResult.Yes)
            {
                db.OgrenciDers.Add(ogrdersekle);
                db.SaveChanges();
                DgvOgrDers.DataSource = db.OgrenciDers.ToList();

                MessageBox.Show("Yeni Öğrenci Dersi Ekleme Başarılı");
                foreach(Control item in Controls)
                {
                    if (item is TextBox) item.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Yeni Kayıt İşlemi İptal Edildi!");
            }
        }

        private void aNASAYFAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anasayfa geri = new Anasayfa();
            geri.ShowDialog();
        }
    }
}