using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            tanisButton.Click += SelamVer;
            tanisButton.Click += KendiniTanit;
        }

        private void SelamVer(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba.");
        }

        private void KendiniTanit(object sender, EventArgs e)
        {
            MessageBox.Show("Ben Sinan.");
        }
    }
}
