namespace Delegate5
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
            this.selamVerButton = new System.Windows.Forms.Button();
            this.kendiniTanitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selamVerButton
            // 
            this.selamVerButton.Location = new System.Drawing.Point(74, 67);
            this.selamVerButton.Name = "selamVerButton";
            this.selamVerButton.Size = new System.Drawing.Size(105, 23);
            this.selamVerButton.TabIndex = 0;
            this.selamVerButton.Text = "Selam Ver";
            this.selamVerButton.UseVisualStyleBackColor = true;
            this.selamVerButton.Click += new System.EventHandler(this.selamVerButton_Click);
            // 
            // kendiniTanitButton
            // 
            this.kendiniTanitButton.Location = new System.Drawing.Point(185, 67);
            this.kendiniTanitButton.Name = "kendiniTanitButton";
            this.kendiniTanitButton.Size = new System.Drawing.Size(105, 23);
            this.kendiniTanitButton.TabIndex = 1;
            this.kendiniTanitButton.Text = "Kendini Tanıt";
            this.kendiniTanitButton.UseVisualStyleBackColor = true;
            this.kendiniTanitButton.Click += new System.EventHandler(this.kendiniTanitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 157);
            this.Controls.Add(this.kendiniTanitButton);
            this.Controls.Add(this.selamVerButton);
            this.Name = "Form1";
            this.Text = "Delegate Örneği 5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button selamVerButton;
        private System.Windows.Forms.Button kendiniTanitButton;
    }
}

