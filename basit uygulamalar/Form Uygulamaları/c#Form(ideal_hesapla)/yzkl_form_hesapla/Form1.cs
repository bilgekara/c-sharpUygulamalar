using System;
using System.Windows.Forms;

namespace yzkl_form_hesapla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int b = int.Parse(textBoxboy.Text);
            int y = int.Parse(textBoxyas.Text);
            int k = int.Parse(textBoxkilo.Text);
            double ideialkilo = 0;
            //if(cinsiyet.SelectedItem=="Kadın")
            if (comboBox1.SelectedIndex == 0)
                ideialkilo = (b - 100) * 0.8 + (y / 10.0);
            else if (comboBox1.SelectedIndex == 1)
                ideialkilo = (b - 100) * 0.9 + (y / 10.0);
            ideialkilo = Math.Round(ideialkilo, 0);
            double fark = ideialkilo - k;
            if (fark > 0)
                label1.Text = fark.ToString() + "kilo almalısınız";
            else if(fark==0)
                label1.Text = "Tebrikler";

            


            label1.Text = "ideal kilonuz" + ideialkilo;
            //MessageBox.Show(""+cinsiyet.Items[0])
            //MessageBox.Show("" + cinsiyet.Items[cinsiyet.selectedindex)
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBoxboy.Text = numericUpDown1.Value.ToString();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBoxyas.Text = hScrollBar1.Value.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBoxboy.Text = trackBar1.Value.ToString();
        }
    }
}
