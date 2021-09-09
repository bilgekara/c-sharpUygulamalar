
namespace FormsAppHayvanCiftligi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonInekYem = new System.Windows.Forms.Button();
            this.pictureBoxInek = new System.Windows.Forms.PictureBox();
            this.progressBarKeci = new System.Windows.Forms.ProgressBar();
            this.labelInekSutu = new System.Windows.Forms.Label();
            this.labelTavukYumurtasi = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelKeciSutu = new System.Windows.Forms.Label();
            this.pictureBoxKeci = new System.Windows.Forms.PictureBox();
            this.progressBarInek = new System.Windows.Forms.ProgressBar();
            this.labelKeci = new System.Windows.Forms.Label();
            this.labelAhir = new System.Windows.Forms.Label();
            this.panelKumes = new System.Windows.Forms.Panel();
            this.buttonOrdekYem = new System.Windows.Forms.Button();
            this.labelOrdek = new System.Windows.Forms.Label();
            this.pictureBoxOrdek = new System.Windows.Forms.PictureBox();
            this.pictureBoxTavuk = new System.Windows.Forms.PictureBox();
            this.labelKumes = new System.Windows.Forms.Label();
            this.labelTavuk = new System.Windows.Forms.Label();
            this.progressBarOrdek = new System.Windows.Forms.ProgressBar();
            this.progressBarTavuk = new System.Windows.Forms.ProgressBar();
            this.buttonTavukYem = new System.Windows.Forms.Button();
            this.labelInek = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelOrdekYumurtasi = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelGidaFabrikasi = new System.Windows.Forms.Panel();
            this.buttonKeciSSAt = new System.Windows.Forms.Button();
            this.buttonInekSSat = new System.Windows.Forms.Button();
            this.buttonOrdekYSat = new System.Windows.Forms.Button();
            this.buttonTavukYSat = new System.Windows.Forms.Button();
            this.labelGidaFabrikasi = new System.Windows.Forms.Label();
            this.panelKasa = new System.Windows.Forms.Panel();
            this.labelTL = new System.Windows.Forms.Label();
            this.labelKasa = new System.Windows.Forms.Label();
            this.panelGecenSure = new System.Windows.Forms.Panel();
            this.labelSN = new System.Windows.Forms.Label();
            this.labelGecenSure = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelUrunDeposu = new System.Windows.Forms.Label();
            this.panelAhir = new System.Windows.Forms.Panel();
            this.buttonKeciYem = new System.Windows.Forms.Button();
            this.labelAdetTavuk = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelnekkg = new System.Windows.Forms.Label();
            this.labelKecikg = new System.Windows.Forms.Label();
            this.labelSNAdet = new System.Windows.Forms.Label();
            this.labelTLAdet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKeci)).BeginInit();
            this.panelKumes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrdek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTavuk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelGidaFabrikasi.SuspendLayout();
            this.panelKasa.SuspendLayout();
            this.panelGecenSure.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelAhir.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonInekYem
            // 
            this.buttonInekYem.BackColor = System.Drawing.SystemColors.Control;
            this.buttonInekYem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonInekYem.ForeColor = System.Drawing.Color.Red;
            this.buttonInekYem.Location = new System.Drawing.Point(174, 151);
            this.buttonInekYem.Name = "buttonInekYem";
            this.buttonInekYem.Size = new System.Drawing.Size(254, 28);
            this.buttonInekYem.TabIndex = 14;
            this.buttonInekYem.Text = "YEM VER";
            this.buttonInekYem.UseVisualStyleBackColor = false;
            this.buttonInekYem.Click += new System.EventHandler(this.buttonInekYem_Click);
            // 
            // pictureBoxInek
            // 
            this.pictureBoxInek.Image = global::FormsAppHayvanCiftligi.Properties.Resources.inek;
            this.pictureBoxInek.Location = new System.Drawing.Point(22, 55);
            this.pictureBoxInek.Name = "pictureBoxInek";
            this.pictureBoxInek.Size = new System.Drawing.Size(130, 124);
            this.pictureBoxInek.TabIndex = 1;
            this.pictureBoxInek.TabStop = false;
            // 
            // progressBarKeci
            // 
            this.progressBarKeci.Location = new System.Drawing.Point(170, 243);
            this.progressBarKeci.Name = "progressBarKeci";
            this.progressBarKeci.Size = new System.Drawing.Size(254, 31);
            this.progressBarKeci.TabIndex = 13;
            this.progressBarKeci.Value = 100;
            // 
            // labelInekSutu
            // 
            this.labelInekSutu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelInekSutu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelInekSutu.ForeColor = System.Drawing.Color.Coral;
            this.labelInekSutu.Location = new System.Drawing.Point(216, 89);
            this.labelInekSutu.Name = "labelInekSutu";
            this.labelInekSutu.Size = new System.Drawing.Size(195, 42);
            this.labelInekSutu.TabIndex = 26;
            this.labelInekSutu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTavukYumurtasi
            // 
            this.labelTavukYumurtasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelTavukYumurtasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTavukYumurtasi.ForeColor = System.Drawing.Color.Coral;
            this.labelTavukYumurtasi.Location = new System.Drawing.Point(11, 89);
            this.labelTavukYumurtasi.Name = "labelTavukYumurtasi";
            this.labelTavukYumurtasi.Size = new System.Drawing.Size(191, 42);
            this.labelTavukYumurtasi.TabIndex = 25;
            this.labelTavukYumurtasi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(200)))), ((int)(((byte)(225)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(217, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 23);
            this.label8.TabIndex = 24;
            this.label8.Text = "İNEK SÜTÜ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(200)))), ((int)(((byte)(225)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(217, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 23);
            this.label7.TabIndex = 23;
            this.label7.Text = "KEÇİ SÜTÜ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(200)))), ((int)(((byte)(225)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(12, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 23);
            this.label6.TabIndex = 22;
            this.label6.Text = "ÖRDEK YUMURTASI";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(200)))), ((int)(((byte)(225)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(15, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "TAVUK YUMURTASI";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelKeciSutu
            // 
            this.labelKeciSutu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelKeciSutu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKeciSutu.ForeColor = System.Drawing.Color.Coral;
            this.labelKeciSutu.Location = new System.Drawing.Point(216, 166);
            this.labelKeciSutu.Name = "labelKeciSutu";
            this.labelKeciSutu.Size = new System.Drawing.Size(195, 42);
            this.labelKeciSutu.TabIndex = 18;
            this.labelKeciSutu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxKeci
            // 
            this.pictureBoxKeci.Image = global::FormsAppHayvanCiftligi.Properties.Resources.keci;
            this.pictureBoxKeci.Location = new System.Drawing.Point(22, 197);
            this.pictureBoxKeci.Name = "pictureBoxKeci";
            this.pictureBoxKeci.Size = new System.Drawing.Size(130, 124);
            this.pictureBoxKeci.TabIndex = 3;
            this.pictureBoxKeci.TabStop = false;
            // 
            // progressBarInek
            // 
            this.progressBarInek.Location = new System.Drawing.Point(174, 104);
            this.progressBarInek.Name = "progressBarInek";
            this.progressBarInek.Size = new System.Drawing.Size(254, 31);
            this.progressBarInek.TabIndex = 8;
            this.progressBarInek.Value = 100;
            // 
            // labelKeci
            // 
            this.labelKeci.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelKeci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKeci.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelKeci.Location = new System.Drawing.Point(170, 197);
            this.labelKeci.Name = "labelKeci";
            this.labelKeci.Size = new System.Drawing.Size(254, 28);
            this.labelKeci.TabIndex = 12;
            this.labelKeci.Text = "CANLI";
            this.labelKeci.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAhir
            // 
            this.labelAhir.BackColor = System.Drawing.Color.Coral;
            this.labelAhir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAhir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelAhir.Location = new System.Drawing.Point(18, 13);
            this.labelAhir.Name = "labelAhir";
            this.labelAhir.Size = new System.Drawing.Size(406, 28);
            this.labelAhir.TabIndex = 10;
            this.labelAhir.Text = "AHIR";
            this.labelAhir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelKumes
            // 
            this.panelKumes.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelKumes.Controls.Add(this.buttonOrdekYem);
            this.panelKumes.Controls.Add(this.labelOrdek);
            this.panelKumes.Controls.Add(this.pictureBoxOrdek);
            this.panelKumes.Controls.Add(this.pictureBoxTavuk);
            this.panelKumes.Controls.Add(this.labelKumes);
            this.panelKumes.Controls.Add(this.labelTavuk);
            this.panelKumes.Controls.Add(this.progressBarOrdek);
            this.panelKumes.Controls.Add(this.progressBarTavuk);
            this.panelKumes.Controls.Add(this.buttonTavukYem);
            this.panelKumes.Location = new System.Drawing.Point(12, 17);
            this.panelKumes.Name = "panelKumes";
            this.panelKumes.Size = new System.Drawing.Size(446, 350);
            this.panelKumes.TabIndex = 11;
            // 
            // buttonOrdekYem
            // 
            this.buttonOrdekYem.BackColor = System.Drawing.SystemColors.Control;
            this.buttonOrdekYem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOrdekYem.ForeColor = System.Drawing.Color.Red;
            this.buttonOrdekYem.Location = new System.Drawing.Point(157, 293);
            this.buttonOrdekYem.Name = "buttonOrdekYem";
            this.buttonOrdekYem.Size = new System.Drawing.Size(254, 28);
            this.buttonOrdekYem.TabIndex = 11;
            this.buttonOrdekYem.Text = "YEM VER";
            this.buttonOrdekYem.UseVisualStyleBackColor = false;
            this.buttonOrdekYem.Click += new System.EventHandler(this.buttonOrdekYem_Click);
            // 
            // labelOrdek
            // 
            this.labelOrdek.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelOrdek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOrdek.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelOrdek.Location = new System.Drawing.Point(157, 204);
            this.labelOrdek.Name = "labelOrdek";
            this.labelOrdek.Size = new System.Drawing.Size(254, 28);
            this.labelOrdek.TabIndex = 10;
            this.labelOrdek.Text = "CANLI";
            this.labelOrdek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxOrdek
            // 
            this.pictureBoxOrdek.Image = global::FormsAppHayvanCiftligi.Properties.Resources.ordek;
            this.pictureBoxOrdek.Location = new System.Drawing.Point(15, 204);
            this.pictureBoxOrdek.Name = "pictureBoxOrdek";
            this.pictureBoxOrdek.Size = new System.Drawing.Size(130, 124);
            this.pictureBoxOrdek.TabIndex = 2;
            this.pictureBoxOrdek.TabStop = false;
            // 
            // pictureBoxTavuk
            // 
            this.pictureBoxTavuk.Image = global::FormsAppHayvanCiftligi.Properties.Resources.tavuk;
            this.pictureBoxTavuk.Location = new System.Drawing.Point(15, 57);
            this.pictureBoxTavuk.Name = "pictureBoxTavuk";
            this.pictureBoxTavuk.Size = new System.Drawing.Size(130, 124);
            this.pictureBoxTavuk.TabIndex = 0;
            this.pictureBoxTavuk.TabStop = false;
            // 
            // labelKumes
            // 
            this.labelKumes.BackColor = System.Drawing.Color.Coral;
            this.labelKumes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKumes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelKumes.Location = new System.Drawing.Point(11, 13);
            this.labelKumes.Name = "labelKumes";
            this.labelKumes.Size = new System.Drawing.Size(400, 28);
            this.labelKumes.TabIndex = 9;
            this.labelKumes.Text = "KÜMES";
            this.labelKumes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTavuk
            // 
            this.labelTavuk.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelTavuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTavuk.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelTavuk.Location = new System.Drawing.Point(157, 57);
            this.labelTavuk.Name = "labelTavuk";
            this.labelTavuk.Size = new System.Drawing.Size(254, 28);
            this.labelTavuk.TabIndex = 8;
            this.labelTavuk.Text = "CANLI";
            this.labelTavuk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBarOrdek
            // 
            this.progressBarOrdek.Location = new System.Drawing.Point(157, 246);
            this.progressBarOrdek.Name = "progressBarOrdek";
            this.progressBarOrdek.Size = new System.Drawing.Size(254, 28);
            this.progressBarOrdek.TabIndex = 7;
            this.progressBarOrdek.Value = 100;
            // 
            // progressBarTavuk
            // 
            this.progressBarTavuk.Location = new System.Drawing.Point(157, 104);
            this.progressBarTavuk.Name = "progressBarTavuk";
            this.progressBarTavuk.Size = new System.Drawing.Size(254, 28);
            this.progressBarTavuk.TabIndex = 6;
            this.progressBarTavuk.Value = 100;
            // 
            // buttonTavukYem
            // 
            this.buttonTavukYem.BackColor = System.Drawing.SystemColors.Control;
            this.buttonTavukYem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTavukYem.ForeColor = System.Drawing.Color.Red;
            this.buttonTavukYem.Location = new System.Drawing.Point(157, 151);
            this.buttonTavukYem.Name = "buttonTavukYem";
            this.buttonTavukYem.Size = new System.Drawing.Size(254, 28);
            this.buttonTavukYem.TabIndex = 4;
            this.buttonTavukYem.Text = "YEM VER";
            this.buttonTavukYem.UseVisualStyleBackColor = false;
            this.buttonTavukYem.Click += new System.EventHandler(this.buttonTavukYem_Click);
            // 
            // labelInek
            // 
            this.labelInek.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelInek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelInek.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelInek.Location = new System.Drawing.Point(174, 57);
            this.labelInek.Name = "labelInek";
            this.labelInek.Size = new System.Drawing.Size(254, 28);
            this.labelInek.TabIndex = 11;
            this.labelInek.Text = "CANLI";
            this.labelInek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelOrdekYumurtasi
            // 
            this.labelOrdekYumurtasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelOrdekYumurtasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOrdekYumurtasi.ForeColor = System.Drawing.Color.Coral;
            this.labelOrdekYumurtasi.Location = new System.Drawing.Point(11, 166);
            this.labelOrdekYumurtasi.Name = "labelOrdekYumurtasi";
            this.labelOrdekYumurtasi.Size = new System.Drawing.Size(195, 42);
            this.labelOrdekYumurtasi.TabIndex = 17;
            this.labelOrdekYumurtasi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Teal;
            this.splitContainer1.Panel1.Controls.Add(this.panelGidaFabrikasi);
            this.splitContainer1.Panel1.Controls.Add(this.panelKasa);
            this.splitContainer1.Panel1.Controls.Add(this.panelGecenSure);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.BurlyWood;
            this.splitContainer1.Panel2.Controls.Add(this.panelAhir);
            this.splitContainer1.Panel2.Controls.Add(this.panelKumes);
            this.splitContainer1.Size = new System.Drawing.Size(938, 644);
            this.splitContainer1.SplitterDistance = 255;
            this.splitContainer1.TabIndex = 1;
            // 
            // panelGidaFabrikasi
            // 
            this.panelGidaFabrikasi.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelGidaFabrikasi.Controls.Add(this.buttonKeciSSAt);
            this.panelGidaFabrikasi.Controls.Add(this.buttonInekSSat);
            this.panelGidaFabrikasi.Controls.Add(this.buttonOrdekYSat);
            this.panelGidaFabrikasi.Controls.Add(this.buttonTavukYSat);
            this.panelGidaFabrikasi.Controls.Add(this.labelGidaFabrikasi);
            this.panelGidaFabrikasi.Location = new System.Drawing.Point(476, 12);
            this.panelGidaFabrikasi.Name = "panelGidaFabrikasi";
            this.panelGidaFabrikasi.Size = new System.Drawing.Size(255, 225);
            this.panelGidaFabrikasi.TabIndex = 5;
            // 
            // buttonKeciSSAt
            // 
            this.buttonKeciSSAt.BackColor = System.Drawing.SystemColors.Control;
            this.buttonKeciSSAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKeciSSAt.ForeColor = System.Drawing.Color.Red;
            this.buttonKeciSSAt.Location = new System.Drawing.Point(22, 180);
            this.buttonKeciSSAt.Name = "buttonKeciSSAt";
            this.buttonKeciSSAt.Size = new System.Drawing.Size(214, 28);
            this.buttonKeciSSAt.TabIndex = 15;
            this.buttonKeciSSAt.Text = "KEÇİ SÜTÜ SAT";
            this.buttonKeciSSAt.UseVisualStyleBackColor = false;
            this.buttonKeciSSAt.Click += new System.EventHandler(this.buttonKeciSSAt_Click);
            // 
            // buttonInekSSat
            // 
            this.buttonInekSSat.BackColor = System.Drawing.SystemColors.Control;
            this.buttonInekSSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonInekSSat.ForeColor = System.Drawing.Color.Red;
            this.buttonInekSSat.Location = new System.Drawing.Point(23, 137);
            this.buttonInekSSat.Name = "buttonInekSSat";
            this.buttonInekSSat.Size = new System.Drawing.Size(214, 28);
            this.buttonInekSSat.TabIndex = 14;
            this.buttonInekSSat.Text = "İNEK SÜTÜ SAT";
            this.buttonInekSSat.UseVisualStyleBackColor = false;
            this.buttonInekSSat.Click += new System.EventHandler(this.buttonInekSSat_Click);
            // 
            // buttonOrdekYSat
            // 
            this.buttonOrdekYSat.BackColor = System.Drawing.SystemColors.Control;
            this.buttonOrdekYSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOrdekYSat.ForeColor = System.Drawing.Color.Red;
            this.buttonOrdekYSat.Location = new System.Drawing.Point(22, 103);
            this.buttonOrdekYSat.Name = "buttonOrdekYSat";
            this.buttonOrdekYSat.Size = new System.Drawing.Size(214, 28);
            this.buttonOrdekYSat.TabIndex = 13;
            this.buttonOrdekYSat.Text = "ÖRDEK YUMURTASI SAT";
            this.buttonOrdekYSat.UseVisualStyleBackColor = false;
            this.buttonOrdekYSat.Click += new System.EventHandler(this.buttonOrdekYSat_Click);
            // 
            // buttonTavukYSat
            // 
            this.buttonTavukYSat.BackColor = System.Drawing.SystemColors.Control;
            this.buttonTavukYSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTavukYSat.ForeColor = System.Drawing.Color.Red;
            this.buttonTavukYSat.Location = new System.Drawing.Point(22, 59);
            this.buttonTavukYSat.Name = "buttonTavukYSat";
            this.buttonTavukYSat.Size = new System.Drawing.Size(214, 28);
            this.buttonTavukYSat.TabIndex = 12;
            this.buttonTavukYSat.Text = "TAVUK YUMURTASI SAT";
            this.buttonTavukYSat.UseVisualStyleBackColor = false;
            this.buttonTavukYSat.Click += new System.EventHandler(this.buttonTavukYSat_Click);
            // 
            // labelGidaFabrikasi
            // 
            this.labelGidaFabrikasi.BackColor = System.Drawing.Color.Coral;
            this.labelGidaFabrikasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGidaFabrikasi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelGidaFabrikasi.Location = new System.Drawing.Point(18, 11);
            this.labelGidaFabrikasi.Name = "labelGidaFabrikasi";
            this.labelGidaFabrikasi.Size = new System.Drawing.Size(218, 28);
            this.labelGidaFabrikasi.TabIndex = 10;
            this.labelGidaFabrikasi.Text = "GIDA FABRİKASI";
            this.labelGidaFabrikasi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelKasa
            // 
            this.panelKasa.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelKasa.Controls.Add(this.labelTLAdet);
            this.panelKasa.Controls.Add(this.labelTL);
            this.panelKasa.Controls.Add(this.labelKasa);
            this.panelKasa.Location = new System.Drawing.Point(753, 132);
            this.panelKasa.Name = "panelKasa";
            this.panelKasa.Size = new System.Drawing.Size(174, 105);
            this.panelKasa.TabIndex = 7;
            // 
            // labelTL
            // 
            this.labelTL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTL.ForeColor = System.Drawing.Color.Coral;
            this.labelTL.Location = new System.Drawing.Point(16, 46);
            this.labelTL.Name = "labelTL";
            this.labelTL.Size = new System.Drawing.Size(139, 42);
            this.labelTL.TabIndex = 13;
            this.labelTL.Text = "0";
            this.labelTL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelKasa
            // 
            this.labelKasa.BackColor = System.Drawing.Color.Coral;
            this.labelKasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKasa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelKasa.Location = new System.Drawing.Point(15, 12);
            this.labelKasa.Name = "labelKasa";
            this.labelKasa.Size = new System.Drawing.Size(140, 28);
            this.labelKasa.TabIndex = 11;
            this.labelKasa.Text = "KASA";
            this.labelKasa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelGecenSure
            // 
            this.panelGecenSure.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelGecenSure.Controls.Add(this.labelSNAdet);
            this.panelGecenSure.Controls.Add(this.labelSN);
            this.panelGecenSure.Controls.Add(this.labelGecenSure);
            this.panelGecenSure.Location = new System.Drawing.Point(753, 12);
            this.panelGecenSure.Name = "panelGecenSure";
            this.panelGecenSure.Size = new System.Drawing.Size(174, 114);
            this.panelGecenSure.TabIndex = 6;
            // 
            // labelSN
            // 
            this.labelSN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSN.ForeColor = System.Drawing.Color.Coral;
            this.labelSN.Location = new System.Drawing.Point(16, 51);
            this.labelSN.Name = "labelSN";
            this.labelSN.Size = new System.Drawing.Size(139, 42);
            this.labelSN.TabIndex = 12;
            this.labelSN.Text = "0";
            this.labelSN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGecenSure
            // 
            this.labelGecenSure.BackColor = System.Drawing.Color.Coral;
            this.labelGecenSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGecenSure.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelGecenSure.Location = new System.Drawing.Point(11, 11);
            this.labelGecenSure.Name = "labelGecenSure";
            this.labelGecenSure.Size = new System.Drawing.Size(144, 28);
            this.labelGecenSure.TabIndex = 11;
            this.labelGecenSure.Text = "GEÇEN SÜRE";
            this.labelGecenSure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.labelKecikg);
            this.panel1.Controls.Add(this.labelnekkg);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelAdetTavuk);
            this.panel1.Controls.Add(this.labelInekSutu);
            this.panel1.Controls.Add(this.labelTavukYumurtasi);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.labelKeciSutu);
            this.panel1.Controls.Add(this.labelOrdekYumurtasi);
            this.panel1.Controls.Add(this.labelUrunDeposu);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 225);
            this.panel1.TabIndex = 4;
            // 
            // labelUrunDeposu
            // 
            this.labelUrunDeposu.BackColor = System.Drawing.Color.Coral;
            this.labelUrunDeposu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUrunDeposu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelUrunDeposu.Location = new System.Drawing.Point(11, 11);
            this.labelUrunDeposu.Name = "labelUrunDeposu";
            this.labelUrunDeposu.Size = new System.Drawing.Size(400, 28);
            this.labelUrunDeposu.TabIndex = 10;
            this.labelUrunDeposu.Text = "ÜRÜN DEPOSU";
            this.labelUrunDeposu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAhir
            // 
            this.panelAhir.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelAhir.Controls.Add(this.buttonKeciYem);
            this.panelAhir.Controls.Add(this.buttonInekYem);
            this.panelAhir.Controls.Add(this.pictureBoxKeci);
            this.panelAhir.Controls.Add(this.pictureBoxInek);
            this.panelAhir.Controls.Add(this.progressBarKeci);
            this.panelAhir.Controls.Add(this.progressBarInek);
            this.panelAhir.Controls.Add(this.labelKeci);
            this.panelAhir.Controls.Add(this.labelInek);
            this.panelAhir.Controls.Add(this.labelAhir);
            this.panelAhir.Location = new System.Drawing.Point(477, 17);
            this.panelAhir.Name = "panelAhir";
            this.panelAhir.Size = new System.Drawing.Size(446, 350);
            this.panelAhir.TabIndex = 12;
            // 
            // buttonKeciYem
            // 
            this.buttonKeciYem.BackColor = System.Drawing.SystemColors.Control;
            this.buttonKeciYem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKeciYem.ForeColor = System.Drawing.Color.Red;
            this.buttonKeciYem.Location = new System.Drawing.Point(170, 293);
            this.buttonKeciYem.Name = "buttonKeciYem";
            this.buttonKeciYem.Size = new System.Drawing.Size(254, 28);
            this.buttonKeciYem.TabIndex = 15;
            this.buttonKeciYem.Text = "YEM VER";
            this.buttonKeciYem.UseVisualStyleBackColor = false;
            this.buttonKeciYem.Click += new System.EventHandler(this.buttonKeciYem_Click);
            // 
            // labelAdetTavuk
            // 
            this.labelAdetTavuk.AutoSize = true;
            this.labelAdetTavuk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelAdetTavuk.Location = new System.Drawing.Point(154, 104);
            this.labelAdetTavuk.Name = "labelAdetTavuk";
            this.labelAdetTavuk.Size = new System.Drawing.Size(36, 17);
            this.labelAdetTavuk.TabIndex = 28;
            this.labelAdetTavuk.Text = "adet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(154, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "adet";
            // 
            // labelnekkg
            // 
            this.labelnekkg.AutoSize = true;
            this.labelnekkg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelnekkg.Location = new System.Drawing.Point(370, 104);
            this.labelnekkg.Name = "labelnekkg";
            this.labelnekkg.Size = new System.Drawing.Size(23, 17);
            this.labelnekkg.TabIndex = 30;
            this.labelnekkg.Text = "kg";
            // 
            // labelKecikg
            // 
            this.labelKecikg.AutoSize = true;
            this.labelKecikg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelKecikg.Location = new System.Drawing.Point(370, 181);
            this.labelKecikg.Name = "labelKecikg";
            this.labelKecikg.Size = new System.Drawing.Size(23, 17);
            this.labelKecikg.TabIndex = 31;
            this.labelKecikg.Text = "kg";
            // 
            // labelSNAdet
            // 
            this.labelSNAdet.AutoSize = true;
            this.labelSNAdet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelSNAdet.Location = new System.Drawing.Point(106, 66);
            this.labelSNAdet.Name = "labelSNAdet";
            this.labelSNAdet.Size = new System.Drawing.Size(27, 17);
            this.labelSNAdet.TabIndex = 32;
            this.labelSNAdet.Text = "SN";
            // 
            // labelTLAdet
            // 
            this.labelTLAdet.AutoSize = true;
            this.labelTLAdet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelTLAdet.Location = new System.Drawing.Point(106, 61);
            this.labelTLAdet.Name = "labelTLAdet";
            this.labelTLAdet.Size = new System.Drawing.Size(25, 17);
            this.labelTLAdet.TabIndex = 31;
            this.labelTLAdet.Text = "TL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 644);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKeci)).EndInit();
            this.panelKumes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrdek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTavuk)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelGidaFabrikasi.ResumeLayout(false);
            this.panelKasa.ResumeLayout(false);
            this.panelKasa.PerformLayout();
            this.panelGecenSure.ResumeLayout(false);
            this.panelGecenSure.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelAhir.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonInekYem;
        private System.Windows.Forms.PictureBox pictureBoxInek;
        private System.Windows.Forms.ProgressBar progressBarKeci;
        private System.Windows.Forms.Label labelInekSutu;
        private System.Windows.Forms.Label labelTavukYumurtasi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelKeciSutu;
        private System.Windows.Forms.PictureBox pictureBoxKeci;
        private System.Windows.Forms.ProgressBar progressBarInek;
        private System.Windows.Forms.Label labelKeci;
        private System.Windows.Forms.Label labelAhir;
        private System.Windows.Forms.Panel panelKumes;
        private System.Windows.Forms.Button buttonOrdekYem;
        private System.Windows.Forms.Label labelOrdek;
        private System.Windows.Forms.PictureBox pictureBoxOrdek;
        private System.Windows.Forms.PictureBox pictureBoxTavuk;
        private System.Windows.Forms.Label labelKumes;
        private System.Windows.Forms.Label labelTavuk;
        private System.Windows.Forms.ProgressBar progressBarOrdek;
        private System.Windows.Forms.ProgressBar progressBarTavuk;
        private System.Windows.Forms.Button buttonTavukYem;
        private System.Windows.Forms.Label labelInek;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelOrdekYumurtasi;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelGidaFabrikasi;
        private System.Windows.Forms.Button buttonKeciSSAt;
        private System.Windows.Forms.Button buttonInekSSat;
        private System.Windows.Forms.Button buttonOrdekYSat;
        private System.Windows.Forms.Button buttonTavukYSat;
        private System.Windows.Forms.Label labelGidaFabrikasi;
        private System.Windows.Forms.Panel panelKasa;
        private System.Windows.Forms.Label labelTL;
        private System.Windows.Forms.Label labelKasa;
        private System.Windows.Forms.Panel panelGecenSure;
        private System.Windows.Forms.Label labelSN;
        private System.Windows.Forms.Label labelGecenSure;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelUrunDeposu;
        private System.Windows.Forms.Panel panelAhir;
        private System.Windows.Forms.Button buttonKeciYem;
        private System.Windows.Forms.Label labelTLAdet;
        private System.Windows.Forms.Label labelSNAdet;
        private System.Windows.Forms.Label labelKecikg;
        private System.Windows.Forms.Label labelnekkg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAdetTavuk;
    }
}

