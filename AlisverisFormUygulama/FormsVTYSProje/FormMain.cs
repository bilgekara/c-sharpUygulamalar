using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsVTYSProje
{
    public partial class FormMain : Form
    {
        #region tanimlamalar
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
         (
               int nLeftRect,
               int nTopRect,
               int nRightRect,
               int nBottomRect,
               int nWidthEllipse,
               int nHeightEllipse

         );
        Config db = new Config();
        GroupBox groupBox;
        PictureBox pictureBox;
        Button btn;
        ArrayList list = new ArrayList();
        ArrayList satir = new ArrayList();

        #endregion

        public FormMain()
        {
            InitializeComponent();
            #region .
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDashbord.Height;
            pnlNav.Top = btnDashbord.Top;
            pnlNav.Left = btnDashbord.Left;
            btnDashbord.BackColor = Color.FromArgb(46, 51, 73);
            #endregion
            db.Connect("shoppingDB");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            #region Urun Listeleme
            flowLayoutPanel1.Controls.Clear();
            string sql = "select " + '"' + "adi" + '"' +
                " from " + '"' + "Urun" + '"';
            string sqlUrl = "select " + '"' + "resimUrl" + '"' +
                " from " + '"' + "Urun" + '"';

            db.ExecuteSelect(sql, "adi");
            int sayi = db.Count();
            for (int i = 0; i < sayi; i++)
            {

                Button btn = new Button();
                btn.Text = "SİPARİŞ VER";
                btn.BackColor = Color.FromArgb(46, 51, 73);
                btn.ForeColor = Color.WhiteSmoke;
                btn.Size = new Size(110, 27);
                groupBox = new GroupBox();
                pictureBox = new PictureBox();
                groupBox.BackColor = Color.WhiteSmoke;
                groupBox.Text = db.Results(i);
                groupBox.Size = new Size(230, 230);
                db.ExecuteSelect(sqlUrl, "resimUrl");
                if (db.Results(i) != string.Empty) pictureBox.Image = Image.FromFile(Application.StartupPath + "\\pic\\" + db.Results(i));

                btn.Location = new Point(60, 200);
                pictureBox.Size = new Size(220, 220);
                pictureBox.Location = new Point(0, 20);
                groupBox.Controls.Add(btn);
                btn.Click += new EventHandler(buttonSiparis_Click);
                groupBox.Controls.Add(pictureBox);
                flowLayoutPanel1.Controls.Add(groupBox);
                db.ExecuteSelect(sql, "adi");
            }
            #endregion
        }


        #region Ana Sayfa
        private void btnDashbord_Click(object sender, EventArgs e)
        {
            #region Urun Listeleme
            #region .
            pnlNav.Height = btnDashbord.Height;
            pnlNav.Top = btnDashbord.Top;
            pnlNav.Left = btnDashbord.Left;
            btnDashbord.BackColor = Color.FromArgb(46, 51, 73);
            #endregion
            flowLayoutPanel1.Controls.Clear();
            string sql = "select " + '"' + "adi" + '"' +
               " from " + '"' + "Urun" + '"';
            string sqlUrl = "select " + '"' + "resimUrl" + '"' +
                " from " + '"' + "Urun" + '"';

            db.ExecuteSelect(sql, "adi");
            int sayi = db.Count();
            for (int i = 0; i < sayi; i++)
            {
                Button btn = new Button();
                btn.Text = "SİPARİŞ VER";
                btn.BackColor = Color.FromArgb(46, 51, 73);
                btn.ForeColor = Color.WhiteSmoke;
                btn.Size = new Size(110, 27);
                btn.Location = new Point(60, 200);
                groupBox = new GroupBox();
                pictureBox = new PictureBox();
                groupBox.BackColor = Color.WhiteSmoke;
                groupBox.Text = db.Results(i);
                groupBox.Size = new Size(230, 230);
                db.ExecuteSelect(sqlUrl, "resimUrl");
                if (db.Results(i) != string.Empty) pictureBox.Image = Image.FromFile(Application.StartupPath + "\\pic\\" + db.Results(i));

                pictureBox.Size = new Size(220, 220);
                pictureBox.Location = new Point(0, 20);
                groupBox.Controls.Add(btn);
                btn.Click += new EventHandler(buttonSiparis_Click);
                groupBox.Controls.Add(pictureBox);
                flowLayoutPanel1.Controls.Add(groupBox);
                db.ExecuteSelect(sql, "adi");
            }
            #endregion
        }
        #endregion

        #region Kategori
        private void btnKategori_Click(object sender, EventArgs e)
        {
            #region .
            pnlNav.Height = btnKategori.Height;
            pnlNav.Top = btnKategori.Top;
            btnKategori.BackColor = Color.FromArgb(46, 51, 73);
            #endregion

            flowLayoutPanel1.Controls.Clear();

            #region Kategori -> Urun
            string sql = "select " + '"' + "Adi" + '"' +
                    " from " + '"' + "Kategori" + '"';


            db.ExecuteSelect(sql, "Adi");
            int sayi = db.Count();

            for (int i = 0; i < sayi; i++)
            {
                btn = new Button();
                list.Add(db.Results(i));
                btn.Text = db.Results(i);
                btn.BackColor = Color.RosyBrown;
                btn.Font = new Font("Nirmala UI", 11, FontStyle.Bold);
                btn.Size = new Size(150, 60);
                btn.Click += new EventHandler(buttonOk_Click);
                flowLayoutPanel1.Controls.Add(btn);
            }
            #endregion
        }
        void buttonOk_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            string[] words = sender.ToString().Split(':');
            words[1] = words[1].Substring(1, words[1].Length - 1);
            string sql = "select " + '"' + "KategoriKodu" + '"' +
                " from " + '"' + "Kategori" + '"' +
                 " where " + '"' + "Adi" + '"' +
                " = '" + words[1] + "';";
            string sqlUrl = "select " + '"' + "resimUrl" + '"' +
               " from " + '"' + "Urun" + '"';
            db.ExecuteSelect(sql, "KategoriKodu"); // kategori id sini donduruyor
            string UrunId = db.Results(0);
            string sqlUrunId = "select " + '"' + "UrunKodu" + '"' +
                " from " + '"' + "UrunKategori" + '"' +
                " where " + '"' + "KategoriKodu" + '"' +
                " = '" + UrunId + "';";
            db.ExecuteSelect(sqlUrunId, "UrunKodu");
            int sayac = db.Count();
            for (int i = 0; i < sayac; i++)
            {
                string id = db.Results(i); // Urun id si
                string sqlUrun = "select " + '"' + "adi" + '"' + "," +
                '"' + "stokmiktari" + '"' +
                " from " + '"' + "Urun" + '"' +
                " where " + '"' + "urunKodu" + '"' +
                " = @" + id;

                db.ExecuteSelect(sqlUrun, "adi");
                for (int j = 0; j < db.Count(); j++)
                {
                    Button btn1 = new Button();
                    btn1.Text = "SİPARİŞ VER";
                    btn1.BackColor = Color.FromArgb(46, 51, 73);
                    btn1.ForeColor = Color.WhiteSmoke;
                    btn1.Size = new Size(110, 27);
                    btn1.Location = new Point(60, 200);
                    groupBox = new GroupBox();
                    groupBox.BackColor = Color.WhiteSmoke;
                    groupBox.Text = db.Results(j);
                    sqlUrl = "select " + '"' + "resimUrl" + '"' + "," +
                '"' + "stokmiktari" + '"' +
                " from " + '"' + "Urun" + '"' +
                " where " + '"' + "urunKodu" + '"' +
                " = @" + id;
                    groupBox.Size = new Size(230, 230);
                    db.ExecuteSelect(sqlUrl, "resimUrl");
                    if (db.Results(0) != string.Empty) pictureBox.Image = Image.FromFile(Application.StartupPath + "\\pic\\" + db.Results(0));

                    pictureBox.Size = new Size(200, 200);
                    pictureBox.Location = new Point(0, 20);
                    groupBox.Controls.Add(btn1);
                    btn1.Click += new EventHandler(buttonSiparis_Click);
                    groupBox.Controls.Add(pictureBox);
                    flowLayoutPanel1.Controls.Add(groupBox);
                    db.ExecuteSelect(sqlUrun, "adi");
                }
                db.ExecuteSelect(sqlUrunId, "UrunKodu");
            }
        }

        #endregion
        void buttonSiparis_Click(object sender, EventArgs e)
        {
            FormSiparis frm = new FormSiparis();
            frm.Show();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnProfil.Height;
            pnlNav.Top = btnProfil.Top;
            btnProfil.BackColor = Color.FromArgb(46, 51, 73);
        }



        #region Leave
        private void btnDashbord_Leave(object sender, EventArgs e)
        {
            btnDashbord.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnKategori_Leave(object sender, EventArgs e)
        {
            btnKategori.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnProfil_Leave(object sender, EventArgs e)
        {
            btnProfil.BackColor = Color.FromArgb(24, 30, 54);
        }
        #endregion

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin frm = new FormLogin();
            frm.Show();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {


            #region Urun Listeleme
            flowLayoutPanel1.Controls.Clear();
            string bol = textBoxSearch.Text.Substring(5);
            string sorgu = "select * from " + '"' + "Urun" + '"' +
                " where " + '"' + "adi" + '"' + " like '%" + bol + "%'";




            db.ExecuteSelect(sorgu, "adi");
            int sayi = db.Count();
            for (int i = 0; i < sayi; i++)
            {

                Button btn = new Button();
                btn.Text = "SİPARİŞ VER";
                btn.BackColor = Color.FromArgb(46, 51, 73);
                btn.ForeColor = Color.WhiteSmoke;
                btn.Size = new Size(110, 27);
                groupBox = new GroupBox();
                pictureBox = new PictureBox();
                groupBox.BackColor = Color.WhiteSmoke;
                groupBox.Text = db.Results(i);
                groupBox.Size = new Size(230, 230);
                string sqlUrl = "select " + '"' + "resimUrl" + '"' +
               " from " + '"' + "Urun" + '"' +
               " where " + '"' + "adi" + '"' + " = '" + db.Results(i) + "';";
                db.ExecuteSelect(sqlUrl, "resimUrl");
                if (db.Results(0) != string.Empty) pictureBox.Image = Image.FromFile(Application.StartupPath + "\\pic\\" + db.Results(0));

                btn.Location = new Point(60, 200);
                pictureBox.Size = new Size(220, 220);
                pictureBox.Location = new Point(0, 20);
                groupBox.Controls.Add(btn);
                btn.Click += new EventHandler(buttonSiparis_Click);
                groupBox.Controls.Add(pictureBox);
                flowLayoutPanel1.Controls.Add(groupBox);
                db.ExecuteSelect(sorgu, "adi");
            }
            #endregion
        }
    }
}
