using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsVTYSProje
{
    public partial class FormRegister : Form
    {
        Config db = new Config();
        public FormRegister()
        {
            InitializeComponent();
            db.Connect("shoppingDB");
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            textBoxUserName.Text = string.Empty;
            textBoxPsw.Text = string.Empty;
            textBoxPsw2.Text = string.Empty;
            textBoxUserName.Focus();
        }

        private void labelGirisYap_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin frm = new FormLogin(); frm.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            
            if (textBoxPsw.Text != textBoxPsw2.Text)
            {
                MessageBox.Show("");
            }
            else
            {
                try 
                {
                    string register = "INSERT INTO " + '"' + "Kullanici" + '"' + "(" + '"' + "kullaniciAdi" + '"' + "," + '"' + "sifre" + '"' + "," + '"' + "rolId" + '"' + ") VALUES('" +
                        textBoxUserName.Text + "','" + textBoxPsw.Text + "','" + "1');";
                    db.ExecuteSql(register);
                    MessageBox.Show("Kullanıcı Başarıyla Kaydedildi");

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Hata : "+ex.Message);
                }
                
            }
       
        }
    }
}
