using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate5
{
    public partial class Form1 : Form
    {
        public delegate void Temsilci(string mesaj);

        private Temsilci _temsilci;

        public Form1()
        {
            InitializeComponent();

            _temsilci = MesajGoster;
        }

        public void MesajGoster(string mesaj)
        {
            MessageBox.Show(mesaj);
        }

        private void selamVerButton_Click(object sender, EventArgs e)
        {
            _temsilci("Merhaba");
        }

        private void kendiniTanitButton_Click(object sender, EventArgs e)
        {
            _temsilci("Ben Sinan.");
        }
    }
}
