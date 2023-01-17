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
    public partial class DersEkleFormu : Form
    {
        ProjeConnectionOkulDbEntities db = new ProjeConnectionOkulDbEntities();

        public DersEkleFormu()
        {
            InitializeComponent();
        }

        private void DersEkle_Load(object sender, EventArgs e)
        {
            dgvDers.DataSource = db.Ders.ToList();
        }

        private void BtnDersEkle_Click(object sender, EventArgs e)
        {
            Ders yenidersekle = new Ders();

            yenidersekle.DersAdi = TxtAd.Text;
            yenidersekle.DersKredisi = int.Parse(TxtKredi.Text);
            yenidersekle.OkulYonetimID = int.Parse(TxtYonetim.Text);

            DialogResult sor = MessageBox.Show("Yeni Kayıt Eklemek İstiyor Musunuz?", "UYARI", MessageBoxButtons.YesNo);
            if (sor == DialogResult.Yes)
            {
                db.Ders.Add(yenidersekle);
                db.SaveChanges();
                dgvDers.DataSource = db.Ders.ToList();

                MessageBox.Show("Yeni Kayıt Ekleme Başarılı");
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
    }
}