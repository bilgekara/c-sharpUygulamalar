using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1, number2, result;
            number1 = int.Parse(txtsayi1.Text);
            number2 = Convert.ToInt32(txtsayi2.Text);
            result = number1 + number2;
            //MessageBox.Show(result.ToString(),"isleminizin sonucu");
            sonuc.Text = result.ToString();
            
        }

        private void result_Click(object sender, EventArgs e)
        {

        }

        private void buttontake_Click(object sender, EventArgs e)
        {
            int number1, number2, result;
            number1 = int.Parse(txtsayi1.Text);
            number2 = Convert.ToInt32(txtsayi2.Text);
            result = number1 - number2;
            MessageBox.Show(result.ToString(), "isleminizin sonucu");
        }
    }
}
