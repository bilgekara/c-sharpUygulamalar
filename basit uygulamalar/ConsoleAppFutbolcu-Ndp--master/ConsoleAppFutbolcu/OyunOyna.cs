using System;
using System.Collections.Generic;
namespace ConsoleAppFutbolcu
{
    class OyunOyna
    {
        Random RastgeleSayi = new Random();
        List<Futbolcu> takim = new List<Futbolcu>();//futbolcu sinifindan liste olusturdum
        public OyunOyna()
        {
            takim.Add(new Defans("Ömer Bayram", 1));//oyunculari listeye atadim
            takim.Add(new Defans("Martin Linnes", 2));
            takim.Add(new Defans("Gökay Güney", 3));
            takim.Add(new Defans("Ahmet Çalık", 4));
            takim.Add(new OrtaSaha("Selçuk İnan", 5));
            takim.Add(new OrtaSaha("Younes Belhanda", 6));
            takim.Add(new OrtaSaha("Ryan Donk", 7));
            takim.Add(new OrtaSaha("Mustafa Kapı", 8));
            takim.Add(new Forvet("Eren Derdiyok", 9));
            takim.Add(new Forvet("Mbaye Diagne", 10));

            int formaNo; int temp = -1; int counter = 0;bool golOlabilir = true;

            do
            {
                formaNo = RastgeleSayi.Next(1, takim.Count);//futbolcuyu forma numarasina gore rastgele sectim
                if (temp != formaNo)//eger rastgele ayni futbolcuyu sectiyse pasver metodunu cagirmiyor
                {
                    takim[formaNo].PasVer();
                    if (!takim[formaNo].KontrolPas()) { Console.WriteLine("Pas başarısız oldu."); golOlabilir = false; break; }//eger pasver basarisizolursa golOlabilirlik durumunu false yaptim
                    temp = formaNo;
                    counter++;//3 kere pas verme olmasi icin pasVer metodu calisirsa count artiyor.
                }
            } while (counter < 3);
            if (golOlabilir)
            {
                do
                {
                    temp = formaNo;
                    formaNo = RastgeleSayi.Next(1, takim.Count);
                } while (temp == formaNo);//pas veren oyuncudan almamasi icin temp degiskeniyle kontrol ediyorum
                Console.WriteLine("SKOR\t\t\t:" + takim[formaNo].GolVurusu());
                takim[formaNo].KontrolGol();
                Console.WriteLine("Oyuncunun İsmi\t\t:" + takim[formaNo].isimSoyisim);
                Console.WriteLine("Oyuncunun Forma Numarası:" + formaNo);
            }
        }
    }
}