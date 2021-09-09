using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Linq_
{
    class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Vaccinated { get; set; }
    }
    class LINQOrnekler
    {
        public void Aggrate1()//ilk parametresi yığın değişkeninin son değerine
                              //ikinci parametresi sıradaki elemanının değerini gosterir
        {
            int[] sayilar = { 4, 8, 8, 3, 9, 0, 7, 8, 2 };
            int toplam = sayilar.Aggregate(0, (total, next) => total + next);
            Console.WriteLine("Sayıların Toplamı:{0}", toplam);
        }
        public void Aggrate2()
        {
            int[] sayilar = { 4, 8, 8, 3, 9, 0, 7, 8, 2 };
            int ciftSayi = sayilar.Aggregate(0, (total, next) =>
               next % 2 == 0 ? total + 1 : total);
            Console.WriteLine("çift sayıların sayısı{0}", ciftSayi);
        }
        public void Aggrate3()
        {
            string cumle = "bugün 23 nisan neşe doluyor insan";
            string[] kelimeler = cumle.Split(' ');
            string tersCumle = kelimeler.Aggregate((guncel, sonraki) => sonraki + " " + guncel);
            Console.WriteLine(tersCumle);
        }
        public void Aggrate4()
        {
            string[] meyveler = { "elma", "erik", "portakal", "çarkıfelek", "üzüm" };
            string enuzunisim = meyveler.Aggregate("ayva",
                (longest, next) =>
                next.Length > longest.Length ? next : longest,
                meyve => meyve.ToUpper());
            Console.WriteLine("en uzun meyve ismi:{0}", enuzunisim);
        }
        public void Any1()
        {
            List<int> sayilar = new List<int> { 1, 2 };
            bool elemanVarmi = sayilar.Any();
            Console.WriteLine("Liste boş{0}.", elemanVarmi ? "değil" : "tur");
        }
        public void Any2()
        {
            Pet[] pets = {new Pet { Name="Karabaş",Age=10,Vaccinated=true},
            new Pet { Name="Kınalı",Age=4,Vaccinated=false},
            new Pet { Name="Havhav",Age=6,Vaccinated=true},
        };
            bool hepsiAyni = pets.All(pet => pet.Name.StartsWith("K"));
            Console.WriteLine("{0}", hepsiAyni ? "Hepsi aynı" : "Aynı değil");
        }
        public void Average1()
        {
            List<int> sayilar1 = new List<int> { 78, 92, 100, 37, 81 };
            double average1 = sayilar1.Average();
            Console.WriteLine("Ortalama:{0}", average1);
            long?[] sayilar2 = { null, 10L, 37L, 399L };
            double? average2 = sayilar2.Average();
            Console.WriteLine("Ortalam:{0}.", average2);

        }
    }
}
