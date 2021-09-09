using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SelamVer(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba.");
        }

        private void yeniButtonOlusturButton_Click(object sender, EventArgs e)
        {
            var yeniButton = new Button();
            yeniButton.Text = "Selam Ver";
            
            /* Eski kullanım şekli */
            //yeniButton.Click += new EventHandler(SelamVer);

            /* Yeni kullanım şekli */
            yeniButton.Click += SelamVer;

            yeniButton.Left = 10;
            yeniButton.Top = 10;

            Controls.Add(yeniButton);
        }
    }
}
