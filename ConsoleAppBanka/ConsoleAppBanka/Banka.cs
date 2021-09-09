using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBanka
{
    abstract class Banka : IBanka
    {
        protected string Ad { get; set; }
        //private string ad;

        //public string Ad
        //{
        //    get { return ad; }
        //    set
        //    {
        //        if (!string.EmptyorNull(value))
        //        {
        //            ad = value;
        //        }
        //        throw new Exception("ad boş olamaz");
        //    }

        //}

        //public long IBAN;

        protected string Soyad { get; set; }
        private int dogumTarihi;
        protected int DogumTarihi
        {
            get { return dogumTarihi; }
            set { if (value < DateTime.Now.Date.Year) dogumTarihi = value; else { Console.WriteLine("Alert!"); } }
        }
        private int yas;
        public int Yas
        {
            get
            {
                return DateTime.Now.Date.Year - DogumTarihi;
            }
            set { yas = value; }
        }
        public virtual void BilgiAl()
        {
            Console.WriteLine("Lütfen adınızı giriniz");
            Ad = Console.ReadLine();
            Console.WriteLine("Lütfen soyadınızı giriniz");
            Soyad = Console.ReadLine();
            Console.WriteLine("Lütfen doğum tarihinizi giriniz");
            DogumTarihi = int.Parse(Console.ReadLine());
        }
    }
    class musteri : Banka, IMusteri
    {
        private int iban;
        private int sifre;
        private int para;
        private string okunanPara;
        public override void BilgiAl()
        {
            base.BilgiAl();
            Console.WriteLine("Lütfen iban numranızı giriniz:"); iban = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen şifrenizi giriniz:"); sifre = int.Parse(Console.ReadLine());
        }
        public void dosyayaYaz()
        {
            string fileName = "musteri.txt"; string writeText = Ad + " " + Soyad + " " + Yas + " " + iban + " " + sifre;
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write); fs.Close();
            File.AppendAllText(fileName, Environment.NewLine + writeText);
        }
        public void MusteriKayit() { BilgiAl(); dosyayaYaz(); }
        public void Para()
        {
            Console.WriteLine("Hesabınızda bulunan para:" + okunanPara);
            Console.Write("Yatıracağınız para:"); para = int.Parse(Console.ReadLine());
        }
        public void ara() { Console.WriteLine("Lütfen şifrenizi giriniz"); sifre = int.Parse(Console.ReadLine()); }
        public void dosyaOku()
        {
            ara();
            int satir = 0;
            string okunan;
            StreamReader st = File.OpenText("musteri.txt");
            TextReader tReader = new StreamReader("para.txt"); string oku = tReader.ReadToEnd(); tReader.Close();
            string[] satirlar = oku.Split('\r', '\n');
            while ((okunan = st.ReadLine()) != null)
            {
                string[] dizi = okunan.Split(' ');
                for (int i = 0; i < dizi.Length; i++)
                {
                    if (dizi[i] == sifre.ToString())
                    {
                        Console.WriteLine("AD  " + "SOYAD  " + "YAS " + "İBAN " + "ŞİFRE");
                        Console.WriteLine(okunan);
                        int j = 0; int mevcutPara = 0;
                        for (int k = 0; k < satirlar.Length; k++)
                        {
                            if (j == satir)
                            {
                                okunanPara = satirlar[j];
                                Para();
                                mevcutPara = int.Parse(okunanPara);
                                mevcutPara += para;
                                satirlar[j] = mevcutPara.ToString();
                                TextWriter tWriter = new StreamWriter("para.txt");

                                tWriter.Write(string.Join("\n", satirlar));
                                tWriter.Flush(); tWriter.Close();
                            }
                            j++;
                        }
                        Console.WriteLine("Mevcut paranız:" + mevcutPara);
                    }
                }
                satir++;
            }
        }
        public void musteriIslem() { dosyaOku(); }
    }
    class personel : Banka,IPersonel
    {
        public override void BilgiAl()
        {
            base.BilgiAl();
        }
        public void dosyayaYaz()
        {
            string fileName = "personel.txt"; string writeText = Ad + " " + Soyad + " " + Yas ;
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write); fs.Close();
            File.AppendAllText(fileName, Environment.NewLine + writeText);
        }
        public void PersonelKayit() { BilgiAl(); dosyayaYaz(); }
        public void Listele()
        {
            string okunan;
            StreamReader st = File.OpenText("musteri.txt");
            Console.WriteLine("İSİM   " + "SOYİSİM  " + "YAŞ     " + "İBAN   " + "ŞİFRE");
            while ((okunan = st.ReadLine()) != null)
            {
                string[] dizi = okunan.Split(' ');
                for (int i = 0; i < 1; i++)
                {
                    EkranaYaz<string>(dizi[i]);
                    EkranaYaz<string>(dizi[i + 1]);
                    EkranaYaz<int>(int.Parse(dizi[i + 2]));
                    EkranaYaz<int>(int.Parse(dizi[i + 3]));
                    EkranaYaz<int>(int.Parse(dizi[i + 4]));
                }
                Console.WriteLine();
            }
        }
        public static void EkranaYaz<S>(S yazilacakNesne)
        {
            Console.Write(yazilacakNesne.ToString() + "\t");
        }
    }

}