namespace vamYontemi
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDepoSayisi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFabrikaSayisi = new System.Windows.Forms.TextBox();
            this.buttonHesapla = new System.Windows.Forms.Button();
            this.listBoxSatirCezalari = new System.Windows.Forms.ListBox();
            this.listBoxSutunCezalari = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelSatirCezalari = new System.Windows.Forms.Label();
            this.labelSutunCezalari = new System.Windows.Forms.Label();
            this.groupBoxToplamMaliyet = new System.Windows.Forms.GroupBox();
            this.labelMaliyet = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel_baslik = new System.Windows.Forms.Panel();
            this.labelBaslik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBoxToplamMaliyet.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel_baslik.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(796, 276);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEkle.Location = new System.Drawing.Point(168, 551);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(492, 52);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kaç Satır Olacak?";
            // 
            // textBoxDepoSayisi
            // 
            this.textBoxDepoSayisi.Location = new System.Drawing.Point(191, 32);
            this.textBoxDepoSayisi.Name = "textBoxDepoSayisi";
            this.textBoxDepoSayisi.Size = new System.Drawing.Size(100, 22);
            this.textBoxDepoSayisi.TabIndex = 6;
            this.textBoxDepoSayisi.TextChanged += new System.EventHandler(this.textBoxDepoSayisi_TextChanged);
            this.textBoxDepoSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDepoSayisi_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kaç Sutun Olacak?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxFabrikaSayisi
            // 
            this.textBoxFabrikaSayisi.Location = new System.Drawing.Point(191, 63);
            this.textBoxFabrikaSayisi.Name = "textBoxFabrikaSayisi";
            this.textBoxFabrikaSayisi.Size = new System.Drawing.Size(100, 22);
            this.textBoxFabrikaSayisi.TabIndex = 8;
            this.textBoxFabrikaSayisi.TextChanged += new System.EventHandler(this.textBoxFabrikaSayisi_TextChanged);
            this.textBoxFabrikaSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFabrikaSayisi_KeyPress);
            // 
            // buttonHesapla
            // 
            this.buttonHesapla.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonHesapla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonHesapla.Location = new System.Drawing.Point(540, 193);
            this.buttonHesapla.Name = "buttonHesapla";
            this.buttonHesapla.Size = new System.Drawing.Size(120, 48);
            this.buttonHesapla.TabIndex = 13;
            this.buttonHesapla.Text = "HESAPLA";
            this.buttonHesapla.UseVisualStyleBackColor = false;
            this.buttonHesapla.Click += new System.EventHandler(this.buttonHesapla_Click);
            // 
            // listBoxSatirCezalari
            // 
            this.listBoxSatirCezalari.FormattingEnabled = true;
            this.listBoxSatirCezalari.ItemHeight = 16;
            this.listBoxSatirCezalari.Location = new System.Drawing.Point(26, 16);
            this.listBoxSatirCezalari.Name = "listBoxSatirCezalari";
            this.listBoxSatirCezalari.Size = new System.Drawing.Size(120, 84);
            this.listBoxSatirCezalari.TabIndex = 16;
            // 
            // listBoxSutunCezalari
            // 
            this.listBoxSutunCezalari.FormattingEnabled = true;
            this.listBoxSutunCezalari.ItemHeight = 16;
            this.listBoxSutunCezalari.Location = new System.Drawing.Point(217, 16);
            this.listBoxSutunCezalari.Name = "listBoxSutunCezalari";
            this.listBoxSutunCezalari.Size = new System.Drawing.Size(120, 84);
            this.listBoxSutunCezalari.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox2.Controls.Add(this.textBoxFabrikaSayisi);
            this.groupBox2.Controls.Add(this.textBoxDepoSayisi);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(22, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 120);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // labelSatirCezalari
            // 
            this.labelSatirCezalari.AutoSize = true;
            this.labelSatirCezalari.BackColor = System.Drawing.Color.RosyBrown;
            this.labelSatirCezalari.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSatirCezalari.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSatirCezalari.Location = new System.Drawing.Point(23, 103);
            this.labelSatirCezalari.Name = "labelSatirCezalari";
            this.labelSatirCezalari.Size = new System.Drawing.Size(116, 17);
            this.labelSatirCezalari.TabIndex = 22;
            this.labelSatirCezalari.Text = "  Satır Cezaları";
            // 
            // labelSutunCezalari
            // 
            this.labelSutunCezalari.AutoSize = true;
            this.labelSutunCezalari.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSutunCezalari.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSutunCezalari.Location = new System.Drawing.Point(223, 103);
            this.labelSutunCezalari.Name = "labelSutunCezalari";
            this.labelSutunCezalari.Size = new System.Drawing.Size(114, 17);
            this.labelSutunCezalari.TabIndex = 23;
            this.labelSutunCezalari.Text = "Sutun Cezaları";
            // 
            // groupBoxToplamMaliyet
            // 
            this.groupBoxToplamMaliyet.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBoxToplamMaliyet.Controls.Add(this.labelMaliyet);
            this.groupBoxToplamMaliyet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxToplamMaliyet.Location = new System.Drawing.Point(22, 177);
            this.groupBoxToplamMaliyet.Name = "groupBoxToplamMaliyet";
            this.groupBoxToplamMaliyet.Size = new System.Drawing.Size(355, 70);
            this.groupBoxToplamMaliyet.TabIndex = 24;
            this.groupBoxToplamMaliyet.TabStop = false;
            this.groupBoxToplamMaliyet.Text = "Toplam Maliyet";
            // 
            // labelMaliyet
            // 
            this.labelMaliyet.AutoSize = true;
            this.labelMaliyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMaliyet.Location = new System.Drawing.Point(141, 22);
            this.labelMaliyet.Name = "labelMaliyet";
            this.labelMaliyet.Size = new System.Drawing.Size(0, 29);
            this.labelMaliyet.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox1.Controls.Add(this.listBoxSatirCezalari);
            this.groupBox1.Controls.Add(this.listBoxSutunCezalari);
            this.groupBox1.Controls.Add(this.labelSutunCezalari);
            this.groupBox1.Controls.Add(this.labelSatirCezalari);
            this.groupBox1.Location = new System.Drawing.Point(442, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 144);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // panel_baslik
            // 
            this.panel_baslik.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel_baslik.Controls.Add(this.labelBaslik);
            this.panel_baslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_baslik.Location = new System.Drawing.Point(0, 0);
            this.panel_baslik.Name = "panel_baslik";
            this.panel_baslik.Size = new System.Drawing.Size(839, 28);
            this.panel_baslik.TabIndex = 25;
            this.panel_baslik.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_baslik_MouseDown);
            this.panel_baslik.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_baslik_MouseMove);
            this.panel_baslik.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_baslik_MouseUp);
            // 
            // labelBaslik
            // 
            this.labelBaslik.AutoSize = true;
            this.labelBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBaslik.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelBaslik.Location = new System.Drawing.Point(321, 0);
            this.labelBaslik.Name = "labelBaslik";
            this.labelBaslik.Size = new System.Drawing.Size(187, 29);
            this.labelBaslik.TabIndex = 0;
            this.labelBaslik.Text = "-VAM Yöntemi-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 615);
            this.Controls.Add(this.panel_baslik);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxToplamMaliyet);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonHesapla);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxToplamMaliyet.ResumeLayout(false);
            this.groupBoxToplamMaliyet.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_baslik.ResumeLayout(false);
            this.panel_baslik.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDepoSayisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFabrikaSayisi;
        private System.Windows.Forms.Button buttonHesapla;
        private System.Windows.Forms.ListBox listBoxSatirCezalari;
        private System.Windows.Forms.ListBox listBoxSutunCezalari;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelSatirCezalari;
        private System.Windows.Forms.Label labelSutunCezalari;
        private System.Windows.Forms.GroupBox groupBoxToplamMaliyet;
        private System.Windows.Forms.Label labelMaliyet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel_baslik;
        private System.Windows.Forms.Label labelBaslik;
    }
}

