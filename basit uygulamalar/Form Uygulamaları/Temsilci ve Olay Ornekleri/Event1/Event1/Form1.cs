using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DugmeyeTiklandi(object sender, EventArgs e)
        {
            MessageBox.Show("Butona tıklandı.");
        }

        private void dugmeOlusturButton_Click(object sender, EventArgs e)
        {
            var dugme = new Dugme();

            dugme.TiklanmaOlayi += DugmeyeTiklandi;

            dugme.Tiklandi();
        }
    }
}
