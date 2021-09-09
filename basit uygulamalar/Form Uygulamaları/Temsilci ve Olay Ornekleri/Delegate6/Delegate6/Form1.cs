using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate6
{
    public partial class Form1 : Form
    {
        private delegate void Komut();

        public Form1()
        {
            InitializeComponent();
        }

        private void SelamVer()
        {
            MessageBox.Show("Merhaba.");
        }

        private void KendiniTanit()
        {
            MessageBox.Show("Ben Sinan.");
        }

        private void KomutCalistir(Komut komut)
        {
            komut();
        }

        private void selamVerButton_Click(object sender, EventArgs e)
        {
            KomutCalistir(SelamVer);
        }

        private void kendiniTanitButton_Click(object sender, EventArgs e)
        {
            KomutCalistir(KendiniTanit);
        }
    }
}
