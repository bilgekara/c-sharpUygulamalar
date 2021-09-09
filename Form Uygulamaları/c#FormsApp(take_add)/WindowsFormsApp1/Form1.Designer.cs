namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lable2 = new System.Windows.Forms.Label();
            this.txtsayi1 = new System.Windows.Forms.TextBox();
            this.txtsayi2 = new System.Windows.Forms.TextBox();
            this.buttonadd = new System.Windows.Forms.Button();
            this.sonuc = new System.Windows.Forms.Label();
            this.buttontake = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(251, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "sayı1";
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lable2.Location = new System.Drawing.Point(251, 152);
            this.lable2.Name = "lable2";
            this.lable2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lable2.Size = new System.Drawing.Size(42, 19);
            this.lable2.TabIndex = 1;
            this.lable2.Text = "sayı2";
            // 
            // txtsayi1
            // 
            this.txtsayi1.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtsayi1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtsayi1.Location = new System.Drawing.Point(310, 98);
            this.txtsayi1.Name = "txtsayi1";
            this.txtsayi1.Size = new System.Drawing.Size(100, 25);
            this.txtsayi1.TabIndex = 2;
            // 
            // txtsayi2
            // 
            this.txtsayi2.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtsayi2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtsayi2.Location = new System.Drawing.Point(310, 152);
            this.txtsayi2.Name = "txtsayi2";
            this.txtsayi2.Size = new System.Drawing.Size(100, 25);
            this.txtsayi2.TabIndex = 3;
            // 
            // buttonadd
            // 
            this.buttonadd.Location = new System.Drawing.Point(466, 98);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(165, 69);
            this.buttonadd.TabIndex = 4;
            this.buttonadd.Text = "add";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.button1_Click);
            // 
            // sonuc
            // 
            this.sonuc.AutoSize = true;
            this.sonuc.BackColor = System.Drawing.Color.Olive;
            this.sonuc.Font = new System.Drawing.Font("Microsoft Office Preview Font", 28.2F, System.Drawing.FontStyle.Bold);
            this.sonuc.Location = new System.Drawing.Point(345, 208);
            this.sonuc.Name = "sonuc";
            this.sonuc.Size = new System.Drawing.Size(0, 64);
            this.sonuc.TabIndex = 5;
            this.sonuc.Click += new System.EventHandler(this.result_Click);
            // 
            // buttontake
            // 
            this.buttontake.Location = new System.Drawing.Point(466, 185);
            this.buttontake.Name = "buttontake";
            this.buttontake.Size = new System.Drawing.Size(165, 66);
            this.buttontake.TabIndex = 6;
            this.buttontake.Text = "take";
            this.buttontake.UseVisualStyleBackColor = true;
            this.buttontake.Click += new System.EventHandler(this.buttontake_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(733, 313);
            this.Controls.Add(this.buttontake);
            this.Controls.Add(this.sonuc);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.txtsayi2);
            this.Controls.Add(this.txtsayi1);
            this.Controls.Add(this.lable2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Office Preview Font", 7.8F);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.TextBox txtsayi1;
        private System.Windows.Forms.TextBox txtsayi2;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Label sonuc;
        private System.Windows.Forms.Button buttontake;
    }
}

