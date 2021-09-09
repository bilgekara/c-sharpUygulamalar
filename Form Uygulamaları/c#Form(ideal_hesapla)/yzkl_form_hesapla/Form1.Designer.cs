namespace yzkl_form_hesapla
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBoxboy = new System.Windows.Forms.TextBox();
            this.labelboy = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelyas = new System.Windows.Forms.Label();
            this.labelkilo = new System.Windows.Forms.Label();
            this.labelcinsiyet = new System.Windows.Forms.Label();
            this.labelsonuc = new System.Windows.Forms.Label();
            this.textBoxyas = new System.Windows.Forms.TextBox();
            this.textBoxkilo = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(640, 27);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(110, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(640, 88);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(110, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBoxboy
            // 
            this.textBoxboy.Location = new System.Drawing.Point(138, 70);
            this.textBoxboy.Name = "textBoxboy";
            this.textBoxboy.Size = new System.Drawing.Size(100, 22);
            this.textBoxboy.TabIndex = 2;
            // 
            // labelboy
            // 
            this.labelboy.AutoSize = true;
            this.labelboy.Location = new System.Drawing.Point(30, 70);
            this.labelboy.Name = "labelboy";
            this.labelboy.Size = new System.Drawing.Size(31, 17);
            this.labelboy.TabIndex = 3;
            this.labelboy.Text = "boy";
            this.labelboy.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 59);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelyas
            // 
            this.labelyas.AutoSize = true;
            this.labelyas.Location = new System.Drawing.Point(30, 108);
            this.labelyas.Name = "labelyas";
            this.labelyas.Size = new System.Drawing.Size(30, 17);
            this.labelyas.TabIndex = 5;
            this.labelyas.Text = "yaş";
            // 
            // labelkilo
            // 
            this.labelkilo.AutoSize = true;
            this.labelkilo.Location = new System.Drawing.Point(30, 150);
            this.labelkilo.Name = "labelkilo";
            this.labelkilo.Size = new System.Drawing.Size(29, 17);
            this.labelkilo.TabIndex = 6;
            this.labelkilo.Text = "kilo";
            // 
            // labelcinsiyet
            // 
            this.labelcinsiyet.AutoSize = true;
            this.labelcinsiyet.Location = new System.Drawing.Point(30, 186);
            this.labelcinsiyet.Name = "labelcinsiyet";
            this.labelcinsiyet.Size = new System.Drawing.Size(55, 17);
            this.labelcinsiyet.TabIndex = 7;
            this.labelcinsiyet.Text = "cinsiyet";
            this.labelcinsiyet.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelsonuc
            // 
            this.labelsonuc.AutoSize = true;
            this.labelsonuc.Location = new System.Drawing.Point(39, 252);
            this.labelsonuc.Name = "labelsonuc";
            this.labelsonuc.Size = new System.Drawing.Size(46, 17);
            this.labelsonuc.TabIndex = 8;
            this.labelsonuc.Text = "sonuç";
            // 
            // textBoxyas
            // 
            this.textBoxyas.Location = new System.Drawing.Point(138, 108);
            this.textBoxyas.Name = "textBoxyas";
            this.textBoxyas.Size = new System.Drawing.Size(100, 22);
            this.textBoxyas.TabIndex = 10;
            // 
            // textBoxkilo
            // 
            this.textBoxkilo.Location = new System.Drawing.Point(138, 150);
            this.textBoxkilo.Name = "textBoxkilo";
            this.textBoxkilo.Size = new System.Drawing.Size(100, 22);
            this.textBoxkilo.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.comboBox1.Location = new System.Drawing.Point(138, 186);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 14;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(294, 70);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            210,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 15;
            this.numericUpDown1.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(431, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 59);
            this.button2.TabIndex = 16;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(288, 108);
            this.hScrollBar1.Maximum = 60;
            this.hScrollBar1.Minimum = 18;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(182, 21);
            this.hScrollBar1.TabIndex = 17;
            this.hScrollBar1.Value = 18;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(288, 147);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 40;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(182, 56);
            this.trackBar1.TabIndex = 18;
            this.trackBar1.Value = 40;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxkilo);
            this.Controls.Add(this.textBoxyas);
            this.Controls.Add(this.labelsonuc);
            this.Controls.Add(this.labelcinsiyet);
            this.Controls.Add(this.labelkilo);
            this.Controls.Add(this.labelyas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelboy);
            this.Controls.Add(this.textBoxboy);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBoxboy;
        private System.Windows.Forms.Label labelboy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelyas;
        private System.Windows.Forms.Label labelkilo;
        private System.Windows.Forms.Label labelcinsiyet;
        private System.Windows.Forms.Label labelsonuc;
        private System.Windows.Forms.TextBox textBoxyas;
        private System.Windows.Forms.TextBox textBoxkilo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

