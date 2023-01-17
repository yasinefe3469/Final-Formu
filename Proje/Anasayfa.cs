using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        public void SetStatus(ToolStripMenuItem toolStripMenuItem)
        {
            toolStripStatusLabel1.Text = toolStripMenuItem.Text + "Tıklandı";
        }

        private void dersleriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ders = new DersFormu();
            ders.MdiParent = this;
            ders.Show();
            SetStatus((ToolStripMenuItem)sender);
        }

        private void yeniDersEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ekle = new DersEkleFormu();
            ekle.MdiParent = this;
            ekle.Show();
            SetStatus((ToolStripMenuItem)sender);
        }

        private void dersGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var guncelle = new DersGuncelleFormu();
            guncelle.MdiParent = this;
            guncelle.Show();
            SetStatus((ToolStripMenuItem)sender);
        }

        private void öğrencileriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ogrenci = new OgrenciFormu();
            ogrenci.MdiParent = this;
            ogrenci.Show();
            SetStatus((ToolStripMenuItem)sender);
        }

        private void yeniÖğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ekle = new OgrenciEkleFormu();
            ekle.MdiParent = this;
            ekle.Show();
            SetStatus((ToolStripMenuItem)sender);
        }

        private void öğrenciGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var guncelle = new OgrenciGuncelleFormu();
            guncelle.MdiParent = this;
            guncelle.Show();
            SetStatus((ToolStripMenuItem)sender);
        }

        private void yöneticileriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var yonetici = new YonetimFormu();
            yonetici.MdiParent = this;
            yonetici.Show();
            SetStatus((ToolStripMenuItem)sender);
        }

        private void yeniYöneticiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ekle = new YonetimEkleFormu();
            ekle.MdiParent = this;
            ekle.Show();
            SetStatus((ToolStripMenuItem)sender);
        }

        private void yöneticiGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var guncelle = new YonetimGuncelleFormu();
            guncelle.MdiParent = this;
            guncelle.Show();
            SetStatus((ToolStripMenuItem)sender);
        }

        private void öğrenciDersleriniListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ogrders = new OgrDersFormu();
            ogrders.MdiParent = this;
            ogrders.Show();
            SetStatus((ToolStripMenuItem)sender);
        }

        private void yeniÖğrenciDersiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ekle = new OgrDersEkleFormu();
            ekle.MdiParent = this;
            ekle.Show();
            SetStatus((ToolStripMenuItem)sender);
        }

        private void öğrenciDersiGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var guncelle = new OgrDersGuncelleFormu();
            guncelle.MdiParent = this;
            guncelle.Show();
            SetStatus((ToolStripMenuItem)sender);
        }
    }
}
