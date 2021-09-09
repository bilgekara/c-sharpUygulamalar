namespace Event4
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
            this.sayacLabel = new System.Windows.Forms.Label();
            this.tiklanmaSayisiBaslikLabel = new System.Windows.Forms.Label();
            this.yeniFormuAcButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sayacLabel
            // 
            this.sayacLabel.AutoSize = true;
            this.sayacLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayacLabel.Location = new System.Drawing.Point(247, 65);
            this.sayacLabel.Name = "sayacLabel";
            this.sayacLabel.Size = new System.Drawing.Size(29, 31);
            this.sayacLabel.TabIndex = 0;
            this.sayacLabel.Text = "0";
            // 
            // tiklanmaSayisiBaslikLabel
            // 
            this.tiklanmaSayisiBaslikLabel.AutoSize = true;
            this.tiklanmaSayisiBaslikLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tiklanmaSayisiBaslikLabel.Location = new System.Drawing.Point(37, 65);
            this.tiklanmaSayisiBaslikLabel.Name = "tiklanmaSayisiBaslikLabel";
            this.tiklanmaSayisiBaslikLabel.Size = new System.Drawing.Size(204, 31);
            this.tiklanmaSayisiBaslikLabel.TabIndex = 1;
            this.tiklanmaSayisiBaslikLabel.Text = "Tıklanma Sayısı";
            // 
            // yeniFormuAcButton
            // 
            this.yeniFormuAcButton.Location = new System.Drawing.Point(101, 121);
            this.yeniFormuAcButton.Name = "yeniFormuAcButton";
            this.yeniFormuAcButton.Size = new System.Drawing.Size(114, 23);
            this.yeniFormuAcButton.TabIndex = 2;
            this.yeniFormuAcButton.Text = "Yeni Formu Aç";
            this.yeniFormuAcButton.UseVisualStyleBackColor = true;
            this.yeniFormuAcButton.Click += new System.EventHandler(this.yeniFormuAcButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 182);
            this.Controls.Add(this.yeniFormuAcButton);
            this.Controls.Add(this.tiklanmaSayisiBaslikLabel);
            this.Controls.Add(this.sayacLabel);
            this.Name = "Form1";
            this.Text = "Event Örneği 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sayacLabel;
        private System.Windows.Forms.Label tiklanmaSayisiBaslikLabel;
        private System.Windows.Forms.Button yeniFormuAcButton;
    }
}

