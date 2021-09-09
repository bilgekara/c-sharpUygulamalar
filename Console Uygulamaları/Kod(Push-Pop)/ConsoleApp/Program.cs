using System;
using System.Collections;
using System.IO;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack ts = new Stack();
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
            StreamReader sr = new StreamReader("veriler.txt");//"veriler.txt" dosyasındaki verileri okuyor
            int sayacPushParantez = 0; int sayacPopParantez = 0;
            int sayacPushKoseli = 0; int sayacPopKoseli = 0;
            int sayacPushSuslu = 0; int sayacPopSuslu = 0;
            char[] karakter = sr.ReadToEnd().ToCharArray();
            for (int i = 0; i < karakter.Length; i++)
            {
                if (karakter[i] == '(')
                {
                    ts.Push(karakter[i]);
                    sayacPushParantez++;
                }

                if (karakter[i] == ')')
                {
                    ts.Pop();
                    sayacPopParantez++;
                }
            }
            for (int i = 0; i < karakter.Length; i++)
            {
                if (karakter[i] == '[')
                {
                    ts.Push(karakter[i]);
                    sayacPushKoseli++;
                }

                if (karakter[i] == ']')
                {
                    ts.Pop();
                    sayacPopKoseli++;
                }
            }
            for (int i = 0; i < karakter.Length; i++)
            {
                if (karakter[i] == '{')
                {
                    ts.Push(karakter[i]);
                    sayacPushSuslu++;
                }

                if (karakter[i] == '}')
                {
                    ts.Pop();
                    sayacPopSuslu++;
                }
            }
            if ((sayacPopParantez == sayacPushParantez) && (sayacPopKoseli == sayacPushKoseli) && (sayacPopSuslu == sayacPushSuslu))
            {
                Console.WriteLine("dengeli");
            }
            else
            {
                Console.WriteLine("dengeli değil");
            }
            Console.ReadKey();
        }
    }
}
