using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tekKullanimlikButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu buton bir daha asla çalışmayacak.");

            tekKullanimlikButton.Click -= tekKullanimlikButton_Click;
        }
    }
}
