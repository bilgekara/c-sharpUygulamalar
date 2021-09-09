using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsAppHayvanCiftligi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            timer1.Interval = 1000;
        }

        HayvanIslem h = new HayvanIslem();


        #region timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            h.paraToplam = int.Parse(labelTL.Text);//tl uzerinde islem yapabilmek icin
            h.SN = int.Parse(labelSN.Text);
            h.SN++;//her timer a girdiginde bir artiyor
            labelSN.Text = h.SN.ToString();//artan zamani label a aktariyoruz

            h.check();//hayvanlar yasiyo mu
            labelTavukYumurtasi.Text = h.tYumurtaAdet.ToString();//tavuk yumurtayı text e yazdıyor
            labelOrdekYumurtasi.Text = h.oYumurtaAdet.ToString();
            labelInekSutu.Text = h.iSutKg.ToString();
            labelKeciSutu.Text = h.kSutKg.ToString();
            //classta kullanabilmek icin
            h.degerAl(progressBarTavuk.Value, progressBarOrdek.Value, progressBarInek.Value, progressBarKeci.Value, labelTavuk.Text, labelOrdek.Text, labelInek.Text, labelKeci.Text);
            h.islem();//progress azaltması
            progressBarTavuk.Value = h.progresTDeger; progressBarOrdek.Value = h.progresODeger; progressBarInek.Value = h.progresIDeger; progressBarKeci.Value = h.progresKDeger;
            labelTavuk.Text = h.tLabel; labelOrdek.Text = h.oLabel; labelInek.Text = h.iLabel; labelKeci.Text = h.kLabel;
        } 
        #endregion

        #region SAT
        private void buttonTavukYSat_Click(object sender, EventArgs e)
        {
            h.tavukYumurtaSat();
            labelTL.Text = h.paraLabel;
        }

        private void buttonOrdekYSat_Click(object sender, EventArgs e)
        {
            h.ordekYumurtaSat();
            labelTL.Text = h.paraLabel;
        }

        private void buttonInekSSat_Click(object sender, EventArgs e)
        {
            h.inekSutSat();
            labelTL.Text = h.paraLabel;
        }

        private void buttonKeciSSAt_Click(object sender, EventArgs e)
        {
            h.keciSutSat();
            labelTL.Text = h.paraLabel;
        }

        #endregion
        #region YEM
        private void buttonTavukYem_Click(object sender, EventArgs e)
        {
            if (h.tavukYasiyo)
            {
                progressBarTavuk.Value = 100;
            }
        }
        private void buttonOrdekYem_Click(object sender, EventArgs e)
        {
            if (h.ordekYasiyo)
            {
                progressBarOrdek.Value = 100;
            }
        }

        private void buttonInekYem_Click(object sender, EventArgs e)
        {
            if (h.inekYasiyo)
            {
                progressBarInek.Value = 100;
            }
        }

        private void buttonKeciYem_Click(object sender, EventArgs e)
        {
            if (h.keciYasiyo)
            {
                progressBarKeci.Value = 100;
            }
        }

        #endregion


    }
}
