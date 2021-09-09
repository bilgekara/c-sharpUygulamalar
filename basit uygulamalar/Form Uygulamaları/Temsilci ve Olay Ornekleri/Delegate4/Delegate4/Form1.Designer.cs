namespace Delegate4
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
            this.calistirButton = new System.Windows.Forms.Button();
            this.komutLabel = new System.Windows.Forms.Label();
            this.komutComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // calistirButton
            // 
            this.calistirButton.Location = new System.Drawing.Point(195, 23);
            this.calistirButton.Name = "calistirButton";
            this.calistirButton.Size = new System.Drawing.Size(75, 23);
            this.calistirButton.TabIndex = 0;
            this.calistirButton.Text = "Çalıştır";
            this.calistirButton.UseVisualStyleBackColor = true;
            this.calistirButton.Click += new System.EventHandler(this.calistirButton_Click);
            // 
            // komutLabel
            // 
            this.komutLabel.AutoSize = true;
            this.komutLabel.Location = new System.Drawing.Point(25, 26);
            this.komutLabel.Name = "komutLabel";
            this.komutLabel.Size = new System.Drawing.Size(37, 13);
            this.komutLabel.TabIndex = 1;
            this.komutLabel.Text = "Komut";
            // 
            // komutComboBox
            // 
            this.komutComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.komutComboBox.FormattingEnabled = true;
            this.komutComboBox.Items.AddRange(new object[] {
            "Selam Ver",
            "Kendini Tanıt"});
            this.komutComboBox.Location = new System.Drawing.Point(68, 23);
            this.komutComboBox.Name = "komutComboBox";
            this.komutComboBox.Size = new System.Drawing.Size(121, 21);
            this.komutComboBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 71);
            this.Controls.Add(this.komutComboBox);
            this.Controls.Add(this.komutLabel);
            this.Controls.Add(this.calistirButton);
            this.Name = "Form1";
            this.Text = "Delegate Örneği 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calistirButton;
        private System.Windows.Forms.Label komutLabel;
        private System.Windows.Forms.ComboBox komutComboBox;
    }
}

