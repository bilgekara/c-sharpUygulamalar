using System;
namespace ConsoleAppFutbolcu
{
    public abstract class Futbolcu//futbolcu sinifindan nesne uremiyor
    {
        Random rnd = new Random();
        public string isimSoyisim { get; set; }
        public int formaNo { get; set; }
        protected float hiz, dayaniklik,pas,sut,yetenek,kararlik,dogalForm,sans;
        private float pasSkor,GolSkor;
        public Futbolcu(string isimSoyisim, int formaNo)
        {
            this.isimSoyisim = isimSoyisim;
            this.formaNo = formaNo;
            hiz = rnd.Next(50, 100);
            dayaniklik = rnd.Next(50, 100);
            pas = rnd.Next(50, 100);
            sut = rnd.Next(50, 100);
            yetenek = rnd.Next(50, 100);
            kararlik = rnd.Next(50, 100);
            dogalForm = rnd.Next(50, 100);
            sans = rnd.Next(50, 100);
        }
        public virtual float PasVer()//turemis sinifta ayni metodu cagirdigimda uzerine yazabilmek icin virtual anahtar kelimesini kullandim
        {
            pasSkor = (pas * 3 / 10) + (yetenek * 3 / 10) + (dayaniklik * 1 / 10) + (dogalForm * 1 / 10) + sans * 2 / 10;
            return pasSkor;
        }
        public virtual float GolVurusu()
        {
            GolSkor = yetenek * 3/10 + sut * 2/10 + kararlik *1/10 + dogalForm *1/10 +hiz * 1/10 + sans * 2/10;
            return GolSkor;
        }

        public virtual bool KontrolPas()//basarili olup olmadigini dondurmesi icin bool verdim
        {
            if (pasSkor > 60) return true;
            else return false;
        }
        public virtual bool KontrolGol()
        {
            if (GolSkor > 70) { Console.WriteLine("\tGOOOOOOOOOOOOLLL"); return true; }
            else { Console.WriteLine("Gol başarısız oldu."); return false; }
        }
    }
    class Defans : Futbolcu
    {
        Random rnd = new Random();
        private float pozisyonAlma,kafa,sicrama;
        private float pasSkor;
        private float GolSkor;
        public Defans(string isimSoyisim, int formaNo) : base(isimSoyisim, formaNo)
        {
            pozisyonAlma = rnd.Next(50, 90);
            kafa = rnd.Next(50, 90);
            sicrama = rnd.Next(50, 90); 
        }
        public override float PasVer()//temel siniftaki ayni isimli metodu kullanabilmeme olanak sagliyor
        {

            pasSkor = (pas * 3 / 10) + (yetenek * 3 / 10) + (dayaniklik * 1 / 10) + (dogalForm * 1 / 10) + sans * 2 / 10 + pozisyonAlma * 1 / 10;
            return pasSkor;
        }
        public override bool KontrolPas()
        {
            if (pasSkor > 60) return true;
            else return false;
        }
        public override float GolVurusu()
        {
            GolSkor = yetenek * 3 / 10 + sut * 2 / 10 + kararlik * 1 / 10 + dogalForm * 1 / 10 + kafa * 1 / 10 + sicrama * 1 / 10 + sans * 1 / 10;
            return GolSkor;
        }
        public override bool KontrolGol()
        {
            if (GolSkor > 70) { Console.WriteLine("\tGOOOOOOOOOOOOLLL"); return true; }
            else { Console.WriteLine("Gol başarısız oldu."); return false; }
        }
    }
    class OrtaSaha : Futbolcu
    {
        Random rnd = new Random();
        private float UzunTop,IlkDokunus,Uretkenlik,TopSurme,OzelYetenek;
        private float pasSkor;
        private float GolSkor;
        public OrtaSaha(string isimSoyisim, int formaNo) : base(isimSoyisim, formaNo)
        {
            UzunTop = rnd.Next(60, 100);
            IlkDokunus = rnd.Next(60, 100);
            Uretkenlik = rnd.Next(60, 100);
            TopSurme = rnd.Next(60, 100);
            OzelYetenek = rnd.Next(60, 100); 
        }
        public override float PasVer()//temel siniftaki ayni isimli metodu kullanabilmeme olanak sagliyor
        {

            pasSkor = (pas * 3 / 10) + (yetenek * 2 / 10) + (OzelYetenek * 2 / 10) + (dayaniklik * 1 / 10) + dogalForm * 1 / 10 + UzunTop * 1 / 10 + TopSurme * 1 / 10 + sans * 1 / 10;
            return pasSkor;
        }
        public override bool KontrolPas()
        {
            if (pasSkor > 60) return true;
            else return false;
        }
        public override float GolVurusu()
        {
            GolSkor = yetenek * 3 / 10 + sut * 2 / 10 + OzelYetenek * 2 / 10 + IlkDokunus * 1 / 10 + kararlik * 1 / 10 + dogalForm * 1 / 10 + sans * 1 / 10;
            return GolSkor;
        }
        
        public override bool KontrolGol()
        {
            if (GolSkor > 70) { Console.WriteLine("\tGOOOOOOOOOOOOLLL"); return true; }
            else { Console.WriteLine("Gol başarısız oldu."); return false; }
        }
    }
    class Forvet : Futbolcu
    {
        Random rnd = new Random();
        private float Bitiricilik,IlkDokunus,Kafa,OzelYetenek,SogukKanlilik;
        private float pasSkor ;
        private float GolSkor;
        public Forvet(string isimSoyisim, int formaNo) : base(isimSoyisim, formaNo)
        {
            Bitiricilik = rnd.Next(70, 100);
            IlkDokunus = rnd.Next(70, 100);
            Kafa = rnd.Next(70, 100);
            OzelYetenek = rnd.Next(70, 100);
            SogukKanlilik = rnd.Next(70, 100);
        }
        public override float PasVer()//temel siniftaki ayni isimli metodu kullanabilmeme olanak sagliyor
        {

            pasSkor = (pas * 3 / 10) + (yetenek * 2 / 10) + (OzelYetenek * 2 / 10) + (dayaniklik * 1 / 10) + (dogalForm * 1 / 10 )+ (sans * 1 / 10);
            return pasSkor;
        }
        public override bool KontrolPas()
        {
            if (pasSkor > 60) return true;
            else return false;
        }
        public override float GolVurusu()
        {
            GolSkor = yetenek * 2 / 10 + sut * 1 / 10 + OzelYetenek * 2 / 10 + IlkDokunus * 1 / 10 + Kafa * 1 / 10 + Bitiricilik * 1 / 10 + SogukKanlilik * 1 / 10 + kararlik * 1 / 10 + dogalForm * 1 / 10 + sans * 1 / 10;
            return GolSkor;
        }
        
        public override bool KontrolGol()
        {
            if (GolSkor > 70) { Console.WriteLine("\tGOOOOOOOOOOOOLLL"); return true; }
            else { Console.WriteLine("Gol başarısız oldu."); return false; }
        }
    }
}
