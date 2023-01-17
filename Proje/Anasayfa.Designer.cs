
namespace Proje
{
    partial class Anasayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersleriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.yeniDersEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dersGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öĞRENCİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrencileriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.yeniÖğrenciEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.öğrenciGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yÖNETİMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yöneticileriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.yeniYöneticiEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.yöneticiGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öĞRENCİDERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciDersleriniListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.yeniÖğrenciDersiEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.öğrenciDersiGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuStrip1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dERSToolStripMenuItem,
            this.öĞRENCİToolStripMenuItem,
            this.yÖNETİMToolStripMenuItem,
            this.öĞRENCİDERSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(844, 29);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "MENÜ";
            // 
            // dERSToolStripMenuItem
            // 
            this.dERSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dersleriListeleToolStripMenuItem,
            this.toolStripSeparator1,
            this.yeniDersEkleToolStripMenuItem,
            this.toolStripSeparator2,
            this.dersGüncelleToolStripMenuItem});
            this.dERSToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.dERSToolStripMenuItem.Name = "dERSToolStripMenuItem";
            this.dERSToolStripMenuItem.Size = new System.Drawing.Size(66, 25);
            this.dERSToolStripMenuItem.Text = "DERS";
            // 
            // dersleriListeleToolStripMenuItem
            // 
            this.dersleriListeleToolStripMenuItem.Name = "dersleriListeleToolStripMenuItem";
            this.dersleriListeleToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.dersleriListeleToolStripMenuItem.Text = "Dersleri Listele";
            this.dersleriListeleToolStripMenuItem.Click += new System.EventHandler(this.dersleriListeleToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(196, 6);
            // 
            // yeniDersEkleToolStripMenuItem
            // 
            this.yeniDersEkleToolStripMenuItem.Name = "yeniDersEkleToolStripMenuItem";
            this.yeniDersEkleToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.yeniDersEkleToolStripMenuItem.Text = "Yeni Ders Ekle";
            this.yeniDersEkleToolStripMenuItem.Click += new System.EventHandler(this.yeniDersEkleToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(196, 6);
            // 
            // dersGüncelleToolStripMenuItem
            // 
            this.dersGüncelleToolStripMenuItem.Name = "dersGüncelleToolStripMenuItem";
            this.dersGüncelleToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.dersGüncelleToolStripMenuItem.Text = "Ders Güncelle";
            this.dersGüncelleToolStripMenuItem.Click += new System.EventHandler(this.dersGüncelleToolStripMenuItem_Click);
            // 
            // öĞRENCİToolStripMenuItem
            // 
            this.öĞRENCİToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrencileriListeleToolStripMenuItem,
            this.toolStripSeparator3,
            this.yeniÖğrenciEkleToolStripMenuItem,
            this.toolStripSeparator4,
            this.öğrenciGüncelleToolStripMenuItem});
            this.öĞRENCİToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.öĞRENCİToolStripMenuItem.Name = "öĞRENCİToolStripMenuItem";
            this.öĞRENCİToolStripMenuItem.Size = new System.Drawing.Size(96, 25);
            this.öĞRENCİToolStripMenuItem.Text = "ÖĞRENCİ";
            // 
            // öğrencileriListeleToolStripMenuItem
            // 
            this.öğrencileriListeleToolStripMenuItem.Name = "öğrencileriListeleToolStripMenuItem";
            this.öğrencileriListeleToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.öğrencileriListeleToolStripMenuItem.Text = "Öğrencileri Listele";
            this.öğrencileriListeleToolStripMenuItem.Click += new System.EventHandler(this.öğrencileriListeleToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(220, 6);
            // 
            // yeniÖğrenciEkleToolStripMenuItem
            // 
            this.yeniÖğrenciEkleToolStripMenuItem.Name = "yeniÖğrenciEkleToolStripMenuItem";
            this.yeniÖğrenciEkleToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.yeniÖğrenciEkleToolStripMenuItem.Text = "Yeni Öğrenci Ekle";
            this.yeniÖğrenciEkleToolStripMenuItem.Click += new System.EventHandler(this.yeniÖğrenciEkleToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(220, 6);
            // 
            // öğrenciGüncelleToolStripMenuItem
            // 
            this.öğrenciGüncelleToolStripMenuItem.Name = "öğrenciGüncelleToolStripMenuItem";
            this.öğrenciGüncelleToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.öğrenciGüncelleToolStripMenuItem.Text = "Öğrenci Güncelle";
            this.öğrenciGüncelleToolStripMenuItem.Click += new System.EventHandler(this.öğrenciGüncelleToolStripMenuItem_Click);
            // 
            // yÖNETİMToolStripMenuItem
            // 
            this.yÖNETİMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yöneticileriListeleToolStripMenuItem,
            this.toolStripSeparator5,
            this.yeniYöneticiEkleToolStripMenuItem,
            this.toolStripSeparator6,
            this.yöneticiGüncelleToolStripMenuItem});
            this.yÖNETİMToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.yÖNETİMToolStripMenuItem.Name = "yÖNETİMToolStripMenuItem";
            this.yÖNETİMToolStripMenuItem.Size = new System.Drawing.Size(99, 25);
            this.yÖNETİMToolStripMenuItem.Text = "YÖNETİM";
            // 
            // yöneticileriListeleToolStripMenuItem
            // 
            this.yöneticileriListeleToolStripMenuItem.Name = "yöneticileriListeleToolStripMenuItem";
            this.yöneticileriListeleToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.yöneticileriListeleToolStripMenuItem.Text = "Yöneticileri Listele";
            this.yöneticileriListeleToolStripMenuItem.Click += new System.EventHandler(this.yöneticileriListeleToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(223, 6);
            // 
            // yeniYöneticiEkleToolStripMenuItem
            // 
            this.yeniYöneticiEkleToolStripMenuItem.Name = "yeniYöneticiEkleToolStripMenuItem";
            this.yeniYöneticiEkleToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.yeniYöneticiEkleToolStripMenuItem.Text = "Yeni Yönetici Ekle";
            this.yeniYöneticiEkleToolStripMenuItem.Click += new System.EventHandler(this.yeniYöneticiEkleToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(223, 6);
            // 
            // yöneticiGüncelleToolStripMenuItem
            // 
            this.yöneticiGüncelleToolStripMenuItem.Name = "yöneticiGüncelleToolStripMenuItem";
            this.yöneticiGüncelleToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.yöneticiGüncelleToolStripMenuItem.Text = "Yönetici Güncelle";
            this.yöneticiGüncelleToolStripMenuItem.Click += new System.EventHandler(this.yöneticiGüncelleToolStripMenuItem_Click);
            // 
            // öĞRENCİDERSToolStripMenuItem
            // 
            this.öĞRENCİDERSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciDersleriniListeleToolStripMenuItem,
            this.toolStripSeparator7,
            this.yeniÖğrenciDersiEkleToolStripMenuItem,
            this.toolStripSeparator8,
            this.öğrenciDersiGüncelleToolStripMenuItem});
            this.öĞRENCİDERSToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.öĞRENCİDERSToolStripMenuItem.Name = "öĞRENCİDERSToolStripMenuItem";
            this.öĞRENCİDERSToolStripMenuItem.Size = new System.Drawing.Size(145, 25);
            this.öĞRENCİDERSToolStripMenuItem.Text = "ÖĞRENCİ DERS";
            // 
            // öğrenciDersleriniListeleToolStripMenuItem
            // 
            this.öğrenciDersleriniListeleToolStripMenuItem.Name = "öğrenciDersleriniListeleToolStripMenuItem";
            this.öğrenciDersleriniListeleToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.öğrenciDersleriniListeleToolStripMenuItem.Text = "Öğrenci Derslerini Listele";
            this.öğrenciDersleriniListeleToolStripMenuItem.Click += new System.EventHandler(this.öğrenciDersleriniListeleToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(276, 6);
            // 
            // yeniÖğrenciDersiEkleToolStripMenuItem
            // 
            this.yeniÖğrenciDersiEkleToolStripMenuItem.Name = "yeniÖğrenciDersiEkleToolStripMenuItem";
            this.yeniÖğrenciDersiEkleToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.yeniÖğrenciDersiEkleToolStripMenuItem.Text = "Yeni Öğrenci Dersi Ekle";
            this.yeniÖğrenciDersiEkleToolStripMenuItem.Click += new System.EventHandler(this.yeniÖğrenciDersiEkleToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(276, 6);
            // 
            // öğrenciDersiGüncelleToolStripMenuItem
            // 
            this.öğrenciDersiGüncelleToolStripMenuItem.Name = "öğrenciDersiGüncelleToolStripMenuItem";
            this.öğrenciDersiGüncelleToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.öğrenciDersiGüncelleToolStripMenuItem.Text = "Öğrenci Dersi Güncelle";
            this.öğrenciDersiGüncelleToolStripMenuItem.Click += new System.EventHandler(this.öğrenciDersiGüncelleToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 589);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(844, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(65, 17);
            this.toolStripStatusLabel1.Text = "ANASAYFA";
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(844, 611);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Anasayfa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANA SAYFA";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dERSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öĞRENCİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öĞRENCİDERSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yÖNETİMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dersleriListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem yeniDersEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem dersGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrencileriListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem yeniÖğrenciEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem öğrenciGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yöneticileriListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem yeniYöneticiEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem yöneticiGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciDersleriniListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem yeniÖğrenciDersiEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem öğrenciDersiGüncelleToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

