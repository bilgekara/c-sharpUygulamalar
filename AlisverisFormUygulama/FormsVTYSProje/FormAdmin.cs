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
    public partial class FormAdmin : Form
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

        public FormAdmin()
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

        private void FormAdmin_Load(object sender, EventArgs e)
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

                btn.Location = new Point(60,200);
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
                    pictureBox.Size = new Size(200, 200);
                    pictureBox.Location = new Point(0, 20);
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
                    if (db.Results(0) != string.Empty) pictureBox.Image = Image.FromFile(Application.StartupPath+"\\pic\\" + db.Results(0));

                    
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








        #region Urun Islemleri
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            #region .
            pnlNav.Height = btnUrunEkle.Height;
            pnlNav.Top = btnUrunEkle.Top;
            btnUrunEkle.BackColor = Color.FromArgb(46, 51, 73);
            #endregion
            #region flowLayout -> Control
            flowLayoutPanel1.Controls.Clear();

            panelUrun1.Controls.Add(labelUrunAdi);
            panelUrun1.Controls.Add(labelStokMiktari);
            panelUrun1.Controls.Add(labelBirimFiyati);
            panelUrun1.Controls.Add(labelUrunAdi);
            panelUrun1.Controls.Add(labelResimURL);



            panelUrun1.Controls.Add(textBoxUrunAdi);
            panelUrun1.Controls.Add(textBoxStokMiktari);
            panelUrun1.Controls.Add(textBoxBirimFiyati);
            panelUrun1.Controls.Add(textBoxResimUrl);

            panelUrun1.Controls.Add(pictureBoxUrun);
            panelUrun1.Controls.Add(buttonResimSec);

            flowLayoutPanel1.Controls.Add(panelUrun1);

            panelUrun2.Controls.Add(dataGridView1);
            panelUrun1.Controls.Add(buttonEkle);
            panelUrun1.Controls.Add(buttonUpdate);
            panelUrun1.Controls.Add(buttonDelete);
            flowLayoutPanel1.Controls.Add(panelUrun2);

            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 4;

            dataGridView1.Columns[0].Name = "Adı";
            dataGridView1.Columns[1].Name = "Stok Miktarı";
            dataGridView1.Columns[2].Name = "Fiyatı";
            dataGridView1.Columns[3].Name = "Resim Adresi";


            db.Execute("cdjn");
            for (int i = 0; i < db.Countt(); i++)
            {
                dataGridView1.Rows.Add(db.Results(i, 1), db.Results(i, 2), db.Results(i, 3), db.Results(i, 4));
            }

            textBoxUrunAdi.Clear();
            textBoxStokMiktari.Clear();
            textBoxBirimFiyati.Clear();
            textBoxResimUrl.Clear();
            pictureBoxUrun.Image = null;
            #endregion
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxUrunAdi.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxStokMiktari.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxBirimFiyati.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxResimUrl.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            pictureBoxUrun.ImageLocation = Application.StartupPath + "\\pic\\" + dataGridView1.CurrentRow.Cells[3].Value.ToString();

            #region combobox -> kategori
            comboBoxKategori.Items.Clear();
            comboBoxKategori.Text = "Kategori";
            string sql = "select " + '"' + "Adi" + '"' +
               " from " + '"' + "Kategori" + '"';


            db.ExecuteSelect(sql, "Adi");
            int sayi = db.Count();
            for (int i = 0; i < sayi; i++)
            {
                comboBoxKategori.Items.Add(db.Results(i));
            }
            #endregion


        }

        #region ADD
        private void buttonEkle_Click(object sender, EventArgs e)
        {
            string[] img = textBoxResimUrl.Text.Split('\\');
            int count = img.Length;
            string sorgu = "Insert into" + '"' + "Urun" + '"' +
                "(" + '"' + "adi" + '"' + "," +
                '"' + "stokmiktari" + '"' + "," +
                '"' + "birimfiyati" + '"' + "," +
                '"' + "resimUrl" + '"' + ")" +
                "values(" + "'" + textBoxUrunAdi.Text + "'" +
                ",'" + textBoxStokMiktari.Text + "','" +
                textBoxBirimFiyati.Text + "','" +
                img[count - 1] + "');";
            db.ExecuteSql(sorgu);
            db.Execute("cdjn");
            MessageBox.Show("Ürün Başarıyla Eklenmiştir");

            #region Kategori Ekle
            string sqlUrunId = "select " + '"' + "urunKodu" + '"' +
                      " from " + '"' + "Urun" + '"' +
                      " where " + '"' + "adi" + '"' + " = '" + textBoxUrunAdi.Text +
                      "'and " + '"' + "stokmiktari" + '"' + " = '" + textBoxStokMiktari.Text +
                      "'and " + '"' + "birimfiyati" + '"' + " = '" + textBoxBirimFiyati.Text +
                      "'and " + '"' + "resimUrl" + '"' + " = '" + img[count - 1] +
                       "';";

            db.ExecuteSelect(sqlUrunId, "UrunKodu");
            string urunKodu = db.Results(0);

            string kategoriId = "select " + '"' + "KategoriKodu" + '"' +
                    " from " + '"' + "Kategori" + '"' +
                    " where " + '"' + "Adi" + '"' + " = '" + comboBoxKategori.SelectedItem.ToString() + "';";

            db.ExecuteSelect(kategoriId, "KategoriKodu");
            string ktgrID = db.Results(0);

            string urnKtgEkle = "INSERT INTO " + '"' + "UrunKategori" + '"' +
                "(" + '"' + "KategoriKodu" + '"' +
                "," + '"' + "UrunKodu" + '"' + ")" +
                " VALUES('" + ktgrID + "','" +
                urunKodu + "');";

            db.ExecuteSql(urnKtgEkle); 
            #endregion
        }
        #endregion

        private void buttonResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            textBoxResimUrl.Text = dosyayolu;
            pictureBoxUrun.ImageLocation = dosyayolu;
        }

        #region UPDATE
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            satir.Clear();
            #region datagridview satır getirme
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int columnIndex = dataGridView1.CurrentCell.ColumnIndex;
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                for (int i = 0; i < 4; i++)
                {
                    satir.Add(dataGridView1.Rows[rowIndex].Cells[i].Value.ToString());
                }

            }
            #endregion

            string[] img = textBoxResimUrl.Text.Split('\\');
            int count = img.Length;

            #region Urun Id
            string sqlUrunId = "select " + '"' + "urunKodu" + '"' + // urun id si seciliyor
                    " from " + '"' + "Urun" + '"' +
                    " where " + '"' + "adi" + '"' + " = '" + satir[0] +
                    "'and " + '"' + "stokmiktari" + '"' + " = '" + satir[1] +
                    "'and " + '"' + "birimfiyati" + '"' + " = '" + satir[2] +
                    "'and " + '"' + "resimUrl" + '"' + " = '" + satir[3] +
                     "';";

            db.ExecuteSelect(sqlUrunId, "UrunKodu"); // urun id bulmak icin sorgu calistirliyor
            string urunKodu = db.Results(0);
            #endregion

            #region Güncelleme
            string sorgu = "Update" + '"' + "Urun" + '"' +  // verilen id ye gore guncelleme sorgusu
                    " Set " + '"' + "adi" + '"' + "='" + textBoxUrunAdi.Text + "'," +
                    '"' + "stokmiktari" + '"' + "='" + textBoxStokMiktari.Text + "'," +
                    '"' + "birimfiyati" + '"' + "='" + textBoxBirimFiyati.Text + "'," +
                    '"' + "resimUrl" + '"' + "='" + img[count - 1] + "'" +
                    "where " + '"' + "urunKodu" + '"' + " = '" + urunKodu + "'";


            db.ExecuteSql(sorgu);
            #endregion


            #region kategori güncellenme
            string kategoriId = "select " + '"' + "KategoriKodu" + '"' +
                    " from " + '"' + "Kategori" + '"' +
                    " where " + '"' + "Adi" + '"' + " = '" + comboBoxKategori.SelectedItem.ToString() + "';";

            db.ExecuteSelect(kategoriId, "KategoriKodu");
            string ktgrID = db.Results(0);

            string urnKtgEkle = "INSERT INTO " + '"' + "UrunKategori" + '"' +
                "(" + '"' + "KategoriKodu" + '"' +
                "," + '"' + "UrunKodu" + '"' + ")" +
                " VALUES('" + ktgrID + "','" +
                urunKodu + "');";

            db.ExecuteSql(urnKtgEkle);
            #endregion

            MessageBox.Show("Ürün Başarıyla Güncellenmiştir");


        }

        #endregion

        #region DELETE
        private void buttonDelete_Click(object sender, EventArgs e)
        {


            #region datagridview satır getirme
            satir.Clear();
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int columnIndex = dataGridView1.CurrentCell.ColumnIndex;
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                for (int i = 0; i < 4; i++)
                {
                    satir.Add(dataGridView1.Rows[rowIndex].Cells[i].Value.ToString());
                    dataGridView1.Rows[rowIndex].Cells[i].Value = "";
                }

            }
            #endregion


            #region Urun Id
            string sqlUrunId = "select " + '"' + "urunKodu" + '"' + //urunun id si
                    " from " + '"' + "Urun" + '"' +
                    " where " + '"' + "adi" + '"' + " = '" + satir[0] +
                    "'and " + '"' + "stokmiktari" + '"' + " = '" + satir[1] +
                    "'and " + '"' + "birimfiyati" + '"' + " = '" + satir[2] +
                    "'and " + '"' + "resimUrl" + '"' + " = '" + satir[3] +
                     "';";

            db.ExecuteSelect(sqlUrunId, "UrunKodu");
            string UrunId = db.Results(0);
            #endregion


            #region UrunKategori tablosundan ürün kısıtları siliniyor
            string ktgrUrunId = "select " + '"' + "Id" + '"' +
                    " from " + '"' + "UrunKategori" + '"' +
                    " where " + '"' + "UrunKodu" + '"' + " = " + "'" + UrunId + "'";
            db.ExecuteSelect(ktgrUrunId, "Id");
            int count = db.Count();
            string KategoriUrunId;
            for (int i = 0; i < count; i++)
            {
                KategoriUrunId = db.Results(i);
                string sq = "Delete From " + '"' + "UrunKategori" + '"' +
                " where " + '"' + "Id" + '"' + "='" + KategoriUrunId + "'";

                db.ExecuteSql(sq);

            }
            #endregion

            #region Ürün siliniyor
            string sorgu = "Delete From " + '"' + "Urun" + '"' +
                    " where " + '"' + "urunKodu" + '"' + "='" + UrunId + "'";

            db.ExecuteSql(sorgu);

            MessageBox.Show("Ürün Başarıyla Silinmiştir"); 
            #endregion

        }
        #endregion

        #endregion



        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            #region .
            pnlNav.Height = btnKategoriEkle.Height;
            pnlNav.Top = btnKategoriEkle.Top;
            btnKategoriEkle.BackColor = Color.FromArgb(46, 51, 73);
            #endregion
            flowLayoutPanel1.Controls.Clear();
            #region silincek
            //flowLayoutPanel1.Controls.Clear();

            //Label label = new Label();
            //label.Text = "Adı :";
            //label.ForeColor = Color.WhiteSmoke;

            //TextBox textBox = new TextBox();
            //textBox.
            //Panel pnl1 = new Panel();
            //pnl1.Controls.Add(label);
            //pnl1.Controls.Add(textBox);

            //Button btnEkle = new Button();
            //btnEkle.Text = "Ekle";
            //btnEkle.ForeColor = Color.WhiteSmoke;

            //Button btnUpdate = new Button();
            //btnUpdate.Text = "Güncelle";

            //Button btnDelete = new Button();
            //btnDelete.Text = "Sil";

            //Panel pnl2 = new Panel();
            //pnl2.Controls.Add(btnEkle);
            //pnl2.Controls.Add(btnUpdate);
            //pnl2.Controls.Add(btnDelete);

            //DataGridView dt = new DataGridView();
            //Panel pnl3 = new Panel();
            //pnl3.Controls.Add(dt);

            //flowLayoutPanel1.Controls.Add(pnl1);
            //flowLayoutPanel1.Controls.Add(pnl2);
            //flowLayoutPanel1.Controls.Add(pnl3); 
            #endregion

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

        private void btnUrunEkle_Leave(object sender, EventArgs e)
        {
            btnUrunEkle.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btnProfil_Leave(object sender, EventArgs e)
        {
            btnProfil.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btnKategoriEkle_Leave(object sender, EventArgs e)
        {
            btnKategoriEkle.BackColor = Color.FromArgb(24, 30, 54);
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
            string bol = textBoxSearch.Text.Substring(7);
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
