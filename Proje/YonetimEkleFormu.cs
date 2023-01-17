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
    public partial class YonetimEkleFormu : Form
    {
        ProjeConnectionOkulDbEntities db = new ProjeConnectionOkulDbEntities();

        public YonetimEkleFormu()
        {
            InitializeComponent();
        }

        private void YonetimEkleFormu_Load(object sender, EventArgs e)
        {
            DgvYonetim.DataSource = db.OkulYonetim.ToList();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            OkulYonetim yoneticiekle = new OkulYonetim();

            yoneticiekle.AdSoyad = TxtAdSoyad.Text;
            yoneticiekle.Gorevi = TxtGorev.Text;

            DialogResult sor = MessageBox.Show("Yeni Yönetici Eklemek İstiyor Musunuz?", "UYARI", MessageBoxButtons.YesNo);
            if (sor == DialogResult.Yes)
            {
                db.OkulYonetim.Add(yoneticiekle);
                db.SaveChanges();
                DgvYonetim.DataSource = db.OkulYonetim.ToList();

                MessageBox.Show("Yeni Yönetici Ekleme Başarılı");
                foreach(Control item in Controls)
                {
                    if (item is TextBox) item.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Yeni Kayıt İşlemi İptal Edildi");
            }
        }
    }
}