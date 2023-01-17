
namespace Proje
{
    partial class OgrenciGuncelleFormu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvOgrenci = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtAdSoyad = new System.Windows.Forms.TextBox();
            this.TxtNo = new System.Windows.Forms.TextBox();
            this.TxtDogumTarihi = new System.Windows.Forms.TextBox();
            this.TxtKayitTarihi = new System.Windows.Forms.TextBox();
            this.TxtBolumu = new System.Windows.Forms.TextBox();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOgrenci)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvOgrenci
            // 
            this.DgvOgrenci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvOgrenci.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DgvOgrenci.BackgroundColor = System.Drawing.Color.White;
            this.DgvOgrenci.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvOgrenci.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvOgrenci.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvOgrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvOgrenci.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvOgrenci.Dock = System.Windows.Forms.DockStyle.Top;
            this.DgvOgrenci.EnableHeadersVisualStyles = false;
            this.DgvOgrenci.Location = new System.Drawing.Point(0, 0);
            this.DgvOgrenci.Name = "DgvOgrenci";
            this.DgvOgrenci.RowHeadersVisible = false;
            this.DgvOgrenci.Size = new System.Drawing.Size(680, 260);
            this.DgvOgrenci.TabIndex = 0;
            this.DgvOgrenci.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOgrenci_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(66, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğrencinin Adı Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(74, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Öğrencinin Numarası:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(45, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Öğrencinin Doğum Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(62, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Öğrencinin Kayıt Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(87, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Öğrencinin Bölümü:";
            // 
            // TxtAdSoyad
            // 
            this.TxtAdSoyad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAdSoyad.Location = new System.Drawing.Point(256, 282);
            this.TxtAdSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAdSoyad.Name = "TxtAdSoyad";
            this.TxtAdSoyad.Size = new System.Drawing.Size(217, 26);
            this.TxtAdSoyad.TabIndex = 2;
            // 
            // TxtNo
            // 
            this.TxtNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtNo.Location = new System.Drawing.Point(256, 316);
            this.TxtNo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNo.Name = "TxtNo";
            this.TxtNo.Size = new System.Drawing.Size(217, 26);
            this.TxtNo.TabIndex = 2;
            // 
            // TxtDogumTarihi
            // 
            this.TxtDogumTarihi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtDogumTarihi.Location = new System.Drawing.Point(256, 350);
            this.TxtDogumTarihi.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDogumTarihi.Name = "TxtDogumTarihi";
            this.TxtDogumTarihi.Size = new System.Drawing.Size(217, 26);
            this.TxtDogumTarihi.TabIndex = 2;
            // 
            // TxtKayitTarihi
            // 
            this.TxtKayitTarihi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKayitTarihi.Location = new System.Drawing.Point(256, 384);
            this.TxtKayitTarihi.Margin = new System.Windows.Forms.Padding(4);
            this.TxtKayitTarihi.Name = "TxtKayitTarihi";
            this.TxtKayitTarihi.Size = new System.Drawing.Size(217, 26);
            this.TxtKayitTarihi.TabIndex = 2;
            // 
            // TxtBolumu
            // 
            this.TxtBolumu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBolumu.Location = new System.Drawing.Point(256, 418);
            this.TxtBolumu.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBolumu.Name = "TxtBolumu";
            this.TxtBolumu.Size = new System.Drawing.Size(217, 26);
            this.TxtBolumu.TabIndex = 2;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuncelle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnGuncelle.Location = new System.Drawing.Point(489, 337);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(170, 50);
            this.BtnGuncelle.TabIndex = 3;
            this.BtnGuncelle.Text = "MEVCUT KAYDI GÜNCELLE";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // OgrenciGuncelleFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(680, 457);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.TxtBolumu);
            this.Controls.Add(this.TxtKayitTarihi);
            this.Controls.Add(this.TxtDogumTarihi);
            this.Controls.Add(this.TxtNo);
            this.Controls.Add(this.TxtAdSoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvOgrenci);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OgrenciGuncelleFormu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÖĞRENCİ GÜNCELLEME FORMU";
            this.Load += new System.EventHandler(this.OgrenciGuncelleFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvOgrenci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvOgrenci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtAdSoyad;
        private System.Windows.Forms.TextBox TxtNo;
        private System.Windows.Forms.TextBox TxtDogumTarihi;
        private System.Windows.Forms.TextBox TxtKayitTarihi;
        private System.Windows.Forms.TextBox TxtBolumu;
        private System.Windows.Forms.Button BtnGuncelle;
    }
}