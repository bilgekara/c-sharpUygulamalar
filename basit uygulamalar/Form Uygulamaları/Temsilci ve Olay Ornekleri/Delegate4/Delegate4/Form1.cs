using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate4
{
    public partial class Form1 : Form
    {
        private delegate void Komut();
        private Dictionary<string, Komut> _komutlar = new Dictionary<string, Komut>();

        public Form1()
        {
            InitializeComponent();

            //_komutlar.Add("Selam Ver", new Komut(SelamVer));
            //_komutlar.Add("Kendini Tanıt", new Komut(KendiniTanit));

            _komutlar.Add("Selam Ver", SelamVer);
            _komutlar.Add("Kendini Tanıt", KendiniTanit);
        }

        private void SelamVer()
        {
            MessageBox.Show("Merhaba.");
        }

        private void KendiniTanit()
        {
            MessageBox.Show("Ben Sinan.");
        }

        private void calistirButton_Click(object sender, EventArgs e)
        {
            _komutlar[komutComboBox.Text]();
        }
    }
}
