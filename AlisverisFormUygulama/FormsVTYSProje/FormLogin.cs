using Npgsql;
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
    public partial class FormLogin : Form
    {
        Config db = new Config();
        public FormLogin()
        {
            InitializeComponent();
            db.Connect("shoppingDB");
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            textBoxUserName.Text = string.Empty;
            textBoxPsw.Text = string.Empty;
            textBoxUserName.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelUyeOl_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegister frm = new FormRegister(); frm.Show();
        }
      
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // Validation check
            if (String.IsNullOrEmpty(textBoxUserName.Text))
            {
                MessageBox.Show("Lütfen kullanıcı adını giriniz");
                return;
            }

            if (String.IsNullOrEmpty(textBoxPsw.Text))
            {
                MessageBox.Show("Lütfen şifrenizi giriniz");
                return;
            }

            try {
                string sql = "SELECT* FROM " +'"'+"Kullanici"+'"'+
                    " WHERE "+'"'+"kullaniciAdi"+'"'+"='"+
                     textBoxUserName.Text + "' and " + '"' + "sifre" + '"' + "='" + textBoxPsw.Text + "';";

                string id = "SELECT" +'"'+"rolId"+'"'+
                    " FROM " + '"' + "Kullanici" + '"' +
                    " WHERE " + '"' + "kullaniciAdi" + '"' + "='" +
                     textBoxUserName.Text + "' and " + '"' + "sifre" + '"' + "='" + textBoxPsw.Text + "';";

                
                if (db.ExecuteLogin(sql))
                {
                    db.ExecuteSelect(id, "rolId");
                    if(db.Results(0)=="0") new FormAdmin().Show();
                    if (db.Results(0)=="1") new FormMain().Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı Lütfen Tekrar Deneyiniz");
                    textBoxPsw.Clear();
                    textBoxUserName.Clear();
                    textBoxUserName.Focus();
                }
            }
            catch { }
        }
    }
}
