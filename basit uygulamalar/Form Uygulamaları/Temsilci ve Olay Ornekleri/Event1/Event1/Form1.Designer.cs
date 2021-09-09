namespace Event1
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
            this.dugmeOlusturButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dugmeOlusturButton
            // 
            this.dugmeOlusturButton.Location = new System.Drawing.Point(158, 44);
            this.dugmeOlusturButton.Name = "dugmeOlusturButton";
            this.dugmeOlusturButton.Size = new System.Drawing.Size(132, 23);
            this.dugmeOlusturButton.TabIndex = 0;
            this.dugmeOlusturButton.Text = "Düğme Oluştur";
            this.dugmeOlusturButton.UseVisualStyleBackColor = true;
            this.dugmeOlusturButton.Click += new System.EventHandler(this.dugmeOlusturButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 115);
            this.Controls.Add(this.dugmeOlusturButton);
            this.Name = "Form1";
            this.Text = "Event Örneği 1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dugmeOlusturButton;
    }
}

