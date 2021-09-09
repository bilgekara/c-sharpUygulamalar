using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delagates
{
    public delegate void MesajVerHandler(string mesaj);
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void KutudaMesajVer(string mesaj)
        {
            MessageBox.Show(mesaj);
        }
        void LabeldaMesajVer(string msg)
        {
            label1.Text = msg;
        }
        void TextBoxdaMesajVer(string msg)
        {
            textBox1.Text = msg;
        }
        void CaptiondaMesajVer(string msg)
        {
            this.Text = msg;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            MesajVerHandler mesajverici = new MesajVerHandler(KutudaMesajVer);//sayici2
            mesajverici += LabeldaMesajVer;
            mesajverici += TextBoxdaMesajVer;
            mesajverici += CaptiondaMesajVer;
            mesajverici.Invoke("Merhaba Dünya");

        }
    }
}
//icerisisnde metot saklayan sey eventHaller
//verdigin metotlari calistiriyo 
//metot yaziyosun hepsi ni calistirabiliyo
//bi program birden fazla işi yurutebiliyo
//cpu ya gelen işlemler thread koridorundan geliyo 
//arka arkaya tek sıra halinde dizilien işlem parcacıgı
//asenkron calistırma alternatif yoldan callback yapacagı iş
//metot degiskende saklanıyo


//private delegate void Komut();
//private Komut komut;

//private void SelamVer()
//{
//    Console.WriteLine(“Merhaba”);
//}

//...

//komut = SelamVer; // Metot değişkende saklanıyor
//komut();




/*private delegate void Komut();
private Dictionary<string, Komut> komutlar;

private void SelamVer()
{
    MessageBox.Show("Merhaba.");
}

private void KendiniTanit()
{
    MessageBox.Show("Ben Sinan.");
}

komutlar = new Dictionary<string, Komut>();

komutlar.Add("Selam Ver", SelamVer);
komutlar.Add("Kendini Tanıt", KendiniTanit);

...

_komutlar["Selam Ver"] ();
_komutlar["Kendini Tanıt"] ();
var yeniButton = new Button();

yeniButton.Text = "Selam Ver";
yeniButton.Left = 10;
yeniButton.Top = 10;

yeniButton.Click += SelamVer;

Controls.Add(yeniButton);





    private delegate void Komut();

private void KomutCalistir(Komut komut)
{
    komut();
}

private void SelamVer()
{
    MessageBox.Show("Merhaba.");
}

private void selamVerButton_Click(object sender, EventArgs e)
{
    KomutCalistir(SelamVer);
}

Olaylar bir nesneyi ilgilendiren herhangi bir durum olduğunda diğer nesneleri bilgilendirmek için kullanılır.


    class Dugme
{
    public event EventHandler TiklanmaOlayi;

    public void Tiklandi()
    {
        if (TiklanmaOlayi == null) return;
        TiklanmaOlayi(this, new EventArgs());
    }
}

...

var dugme = new Dugme();
dugme.TiklanmaOlayi += DugmeyeTiklandi;
dugme.Tiklandi();
    */













    //class Hast<Temsili,IlacTip> where IlacTip:IlacTip//ILactip sadece Ilactan kalıtım alabilir
