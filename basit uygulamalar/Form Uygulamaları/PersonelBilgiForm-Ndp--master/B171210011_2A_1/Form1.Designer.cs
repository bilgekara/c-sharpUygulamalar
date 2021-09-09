namespace B171210011_2A_1
{
    partial class Form1
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
            this.buttonGoster = new System.Windows.Forms.Button();
            this.textBoxTC = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderTC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderYas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCalisma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEvlilik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEsi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCocuk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTaban = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMakam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderİdari = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMesaiS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMesaiU = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderVergi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGoster
            // 
            this.buttonGoster.Location = new System.Drawing.Point(46, 115);
            this.buttonGoster.Name = "buttonGoster";
            this.buttonGoster.Size = new System.Drawing.Size(174, 40);
            this.buttonGoster.TabIndex = 0;
            this.buttonGoster.Text = "Personel Arat";
            this.buttonGoster.UseVisualStyleBackColor = true;
            this.buttonGoster.Click += new System.EventHandler(this.buttonGoster_Click);
            // 
            // textBoxTC
            // 
            this.textBoxTC.Location = new System.Drawing.Point(46, 49);
            this.textBoxTC.Name = "textBoxTC";
            this.textBoxTC.Size = new System.Drawing.Size(174, 22);
            this.textBoxTC.TabIndex = 1;
            this.textBoxTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTC_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::B171210011_2A_1.Properties.Resources.profil;
            this.pictureBox1.Location = new System.Drawing.Point(639, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 143);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Personel Maaşı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(835, 233);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Bilgileri";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTC,
            this.columnHeaderAd,
            this.columnHeaderSoyad,
            this.columnHeaderYas,
            this.columnHeaderCalisma,
            this.columnHeaderEvlilik,
            this.columnHeaderEsi,
            this.columnHeaderCocuk,
            this.columnHeaderTaban,
            this.columnHeaderMakam,
            this.columnHeaderİdari,
            this.columnHeaderMesaiS,
            this.columnHeaderMesaiU,
            this.columnHeaderVergi});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 21);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(817, 197);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderTC
            // 
            this.columnHeaderTC.Text = "TC";
            // 
            // columnHeaderAd
            // 
            this.columnHeaderAd.Text = "Ad";
            // 
            // columnHeaderSoyad
            // 
            this.columnHeaderSoyad.Text = "Soyad";
            // 
            // columnHeaderYas
            // 
            this.columnHeaderYas.Text = "Yaş";
            // 
            // columnHeaderCalisma
            // 
            this.columnHeaderCalisma.Text = "Çalışma Süresi";
            // 
            // columnHeaderEvlilik
            // 
            this.columnHeaderEvlilik.Text = "Evlilik Durumu";
            // 
            // columnHeaderEsi
            // 
            this.columnHeaderEsi.Text = "Eşi Çalışıyor mu";
            this.columnHeaderEsi.Width = 62;
            // 
            // columnHeaderCocuk
            // 
            this.columnHeaderCocuk.Text = "Çocuk Sayısı";
            // 
            // columnHeaderTaban
            // 
            this.columnHeaderTaban.Text = "Taban Maaş";
            // 
            // columnHeaderMakam
            // 
            this.columnHeaderMakam.Text = "Makam Tazminatı";
            // 
            // columnHeaderİdari
            // 
            this.columnHeaderİdari.Text = "İdari Görev Tazminatı";
            this.columnHeaderİdari.Width = 46;
            // 
            // columnHeaderMesaiS
            // 
            this.columnHeaderMesaiS.Text = "Fazla Mesai Saati";
            this.columnHeaderMesaiS.Width = 33;
            // 
            // columnHeaderMesaiU
            // 
            this.columnHeaderMesaiU.Text = "Fazla Mesai Ücreti";
            this.columnHeaderMesaiU.Width = 126;
            // 
            // columnHeaderVergi
            // 
            this.columnHeaderVergi.Text = "Vergi Matrahı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 459);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxTC);
            this.Controls.Add(this.buttonGoster);
            this.Name = "Form1";
            this.Text = "Personel Bilgi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGoster;
        private System.Windows.Forms.TextBox textBoxTC;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderTC;
        private System.Windows.Forms.ColumnHeader columnHeaderAd;
        private System.Windows.Forms.ColumnHeader columnHeaderSoyad;
        private System.Windows.Forms.ColumnHeader columnHeaderYas;
        private System.Windows.Forms.ColumnHeader columnHeaderCalisma;
        private System.Windows.Forms.ColumnHeader columnHeaderEvlilik;
        private System.Windows.Forms.ColumnHeader columnHeaderEsi;
        private System.Windows.Forms.ColumnHeader columnHeaderCocuk;
        private System.Windows.Forms.ColumnHeader columnHeaderTaban;
        private System.Windows.Forms.ColumnHeader columnHeaderMakam;
        private System.Windows.Forms.ColumnHeader columnHeaderİdari;
        private System.Windows.Forms.ColumnHeader columnHeaderMesaiS;
        private System.Windows.Forms.ColumnHeader columnHeaderMesaiU;
        private System.Windows.Forms.ColumnHeader columnHeaderVergi;
    }
}

