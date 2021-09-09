/******************************************************
Personel bilgilerini txt dosyasından cekip personelin resmini gösteren ve maasini hesaplayan program.
*****************************************************/
/*RESİM KLASORU YEREL DİSK C'YE KONULACAK*/
using System;
using System.IO;
using System.Windows.Forms;

namespace B171210011_2A_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            try//try cath ile oluşabilecek hataları yakalıyoruz
            {
                StreamReader dosya = File.OpenText("veriler.txt");//veriler txt dosyaysını okuyor
                dosya.Close();//dosyayı kapatıyor eğer kapatmazsak "şuan işlem yapıldığından dosya kullanılamıyor"gibi bir hata ile karşılaşabiliriz
            }
            catch (Exception)//dosyayı okumadığı takdirde buraya giriyor ve yeni bir dosya yaratıyor
            {
                StreamWriter dosya = File.CreateText("veriler.txt"); //StreamWriter sınıfı ile metin dosyalarına karakter türünde değer girişi yapılmaktadır.
                dosya.Close();
            }
            InitializeComponent();
        }

        private void buttonGoster_Click(object sender, EventArgs e)
        {
            if (textBoxTC.Text == "") { MessageBox.Show("Lütfen Personelin kimlik numarasını giriniz."); }
            else
            {
                if (Convert.ToInt32(textBoxTC.Text.Length) == 11)
                {
                    StreamReader sr = new StreamReader("veriler.txt");//"veriler.txt" dosyasındaki verileri okuyor
                    string line = sr.ReadLine(); //okudugunu line adlı string diziye atiyor
                    string[] words;//her okudugum satiri bu diziye atayip islem yapicam
                    Maas m = new Maas();//maas class'ından m nesnesi olusturuyorum(class ozelliklerini kullanabilmek icin)
                    m.brutMaas = 0;
                    m.gelir = 0;
                    int sayacSatir = 0;
                    int sayac = 0;
                    while (line != null)//satir bosluga esit olana kadar bu islemleri yapacak
                    {
                        sayacSatir++;
                        words = line.Split(' ');//txt dosyasini bosluklara gore bolup bu diziye atiyorum
                        if (textBoxTC.Text == words[0])//txtBox girilen veri personelin TC sine esitse
                        {
                            pictureBox1.ImageLocation = Application.StartupPath+words[14];
                            ListViewItem lst = new ListViewItem(words);
                            listView1.Items.Add(lst);//listview bilgileri ekliyoruz
                            #region Maas Hesaplama
                            if (words[5] == "B")//BEKAR
                            {
                                m.brutMaas += float.Parse(words[8]) + float.Parse(words[9]) + float.Parse(words[10]) + float.Parse(words[7]) * 30 + float.Parse(words[11]) * float.Parse(words[12]);
                            }
                            else//EVLİ
                            {
                                if (words[6] == "E")//esi var
                                {
                                    m.brutMaas = float.Parse(words[8]) + float.Parse(words[9]) + float.Parse(words[10]) + float.Parse(words[7]) * 30 + float.Parse(words[11]) * float.Parse(words[12]);
                                }
                                else if (words[6] == "H")//esi yok
                                {
                                    m.brutMaas = float.Parse(words[8]) + float.Parse(words[9]) + float.Parse(words[10]) + float.Parse(words[7]) * 30 + float.Parse(words[11]) * float.Parse(words[12]) + 200;
                                }
                            }
                            m.damgaVergisi = m.brutMaas * 10 / 100;
                            m.gelirVergisi = float.Parse(words[13]);
                            if (m.gelirVergisi < 10000)
                            {
                                m.gelir = m.brutMaas * 15 / 100;
                            }
                            else if (m.gelirVergisi >= 10000 && m.gelirVergisi < 20000)
                            {
                                m.gelir = m.brutMaas * 20 / 100;

                            }
                            else if (m.gelirVergisi >= 20000 && m.gelirVergisi < 30000)
                            {
                                m.gelir = m.brutMaas * 25 / 100;
                            }
                            else if (m.gelirVergisi >= 30000)
                            {
                                m.gelir = m.brutMaas * 30 / 100;
                            }

                            label2.Text = m.maasHesapla().ToString();
                            #endregion
                        }
                        else//eger textBox tan girilen veri TC ye esit degilse sayaci artiriyor
                        {
                            sayac++;
                        }
                        line = sr.ReadLine();
                    }
                    if (sayacSatir == sayac)//eger personele ait TC bulamadıysa satir ve sayac sayisi esit cikiyor
                    {
                        MessageBox.Show("Böyle bir kayıt bulunmamaktadır.");
                        textBoxTC.Text = "";
                        textBoxTC.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("TC 11 haneden oluşmalı");
                    textBoxTC.Text = "";
                    textBoxTC.Focus();
                }
            }
        }
        private void textBoxTC_KeyPress(object sender, KeyPressEventArgs e)//karakter girimine izin vermiyorum
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
