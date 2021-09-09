using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yeniFormuAcButton_Click(object sender, EventArgs e)
        {
            var yeniForm = new YeniForm();
            yeniForm.SayButonunaTiklandi += SayaciArttir;
            yeniForm.ShowDialog();
        }

        private void SayaciArttir(object sender, EventArgs e)
        {
            sayacLabel.Text = Convert.ToString(Convert.ToInt32(sayacLabel.Text) + 1);
        }
    }
}
