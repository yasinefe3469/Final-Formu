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
    public partial class OgrenciEkleFormu : Form
    {
        ProjeConnectionOkulDbEntities db = new ProjeConnectionOkulDbEntities();

        public OgrenciEkleFormu()
        {
            InitializeComponent();
        }

        private void OgrenciEkleFormu_Load(object sender, EventArgs e)
        {
            DgvOgrenci.DataSource = db.Ogrenci.ToList();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            Ogrenci yeniogrenciekle = new Ogrenci();

            yeniogrenciekle.OgrenciAdiSoyadi = TxtAdSoyad.Text;
            yeniogrenciekle.OgrenciNo = int.Parse(TxtNo.Text);
            yeniogrenciekle.OgrenciDogumTarihi = DateTime.Parse(TxtDogumTarihi.Text);
            yeniogrenciekle.OgrenciKayitTarihi = DateTime.Parse(TxtKayitTarihi.Text);
            yeniogrenciekle.OgrenciBolumu = TxtBolum.Text;

            DialogResult sor = MessageBox.Show("Yeni Öğrenci Eklemek İstiyor Musunuz?", "UYARI", MessageBoxButtons.YesNo);
            if (sor == DialogResult.Yes)
            {
                db.Ogrenci.Add(yeniogrenciekle);
                db.SaveChanges();
                DgvOgrenci.DataSource = db.Ogrenci.ToList();

                MessageBox.Show("Yeni Öğrenci Ekleme Başarılı");
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