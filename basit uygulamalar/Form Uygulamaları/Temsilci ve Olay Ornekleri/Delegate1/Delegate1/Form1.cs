using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate1
{
    public partial class Form1 : Form
    {
        public delegate void Temsilci();

        private Temsilci _temsilci;

        public Form1()
        {
            InitializeComponent();
        }

        public void SelamVer()
        {
            MessageBox.Show("Merhaba.");
        }

        public void KendiniTanit()
        {
            MessageBox.Show("Ben Sinan.");
        }

        private void selamVerButton_Click(object sender, EventArgs e)
        {

            //_temsilci = new Temsilci(SelamVer); /* Eski (açık) kullanım şekli*/
            _temsilci = SelamVer; /* Yeni kullanım şekli */
            _temsilci();
        }

        private void kendiniTanitButton_Click(object sender, EventArgs e)
        {
            _temsilci = KendiniTanit;
            _temsilci();
        }
    }
}
