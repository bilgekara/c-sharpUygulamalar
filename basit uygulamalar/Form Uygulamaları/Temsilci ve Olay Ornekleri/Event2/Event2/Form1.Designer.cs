namespace Event2
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
            this.birinciButton = new System.Windows.Forms.Button();
            this.ikinciButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // birinciButton
            // 
            this.birinciButton.Location = new System.Drawing.Point(32, 30);
            this.birinciButton.Name = "birinciButton";
            this.birinciButton.Size = new System.Drawing.Size(101, 23);
            this.birinciButton.TabIndex = 0;
            this.birinciButton.Text = "Birinci Button";
            this.birinciButton.UseVisualStyleBackColor = true;
            // 
            // ikinciButton
            // 
            this.ikinciButton.Location = new System.Drawing.Point(32, 71);
            this.ikinciButton.Name = "ikinciButton";
            this.ikinciButton.Size = new System.Drawing.Size(101, 23);
            this.ikinciButton.TabIndex = 1;
            this.ikinciButton.Text = "İkinci Button";
            this.ikinciButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 137);
            this.Controls.Add(this.ikinciButton);
            this.Controls.Add(this.birinciButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button birinciButton;
        private System.Windows.Forms.Button ikinciButton;
    }
}

