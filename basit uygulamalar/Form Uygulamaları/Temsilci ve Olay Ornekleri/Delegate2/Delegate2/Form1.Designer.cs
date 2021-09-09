namespace Delegate2
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
            this.yeniButtonOlusturButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yeniButtonOlusturButton
            // 
            this.yeniButtonOlusturButton.Location = new System.Drawing.Point(136, 65);
            this.yeniButtonOlusturButton.Name = "yeniButtonOlusturButton";
            this.yeniButtonOlusturButton.Size = new System.Drawing.Size(112, 23);
            this.yeniButtonOlusturButton.TabIndex = 0;
            this.yeniButtonOlusturButton.Text = "Yeni Button Oluştur";
            this.yeniButtonOlusturButton.UseVisualStyleBackColor = true;
            this.yeniButtonOlusturButton.Click += new System.EventHandler(this.yeniButtonOlusturButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 102);
            this.Controls.Add(this.yeniButtonOlusturButton);
            this.Name = "Form1";
            this.Text = "Delegate Örneği 2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button yeniButtonOlusturButton;
    }
}

