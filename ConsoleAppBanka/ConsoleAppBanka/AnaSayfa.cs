using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBanka
{
    class AnaSayfa
    {
        public AnaSayfa()
        {
            personel p = new personel(); musteri m = new musteri();

            Console.WriteLine("1-Müşteri İşlemleri");
            Console.WriteLine("2-Personel İşlemleri");
            int secim = int.Parse(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("1-Müşteri Kayıt");
                    Console.WriteLine("2-Para Yatırma,Çekme");
                    int secimMusteri = int.Parse(Console.ReadLine());
                    switch (secimMusteri)
                    {
                        case 1:
                            Console.Clear();
                            m.MusteriKayit();
                            break;
                        case 2:
                            Console.Clear();
                            m.musteriIslem();
                            break;
                    }
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("1-Personel Kayıt");
                    Console.WriteLine("2-Müşterileri Listele");
                    int secimPersonel = int.Parse(Console.ReadLine());
                    switch (secimPersonel)
                    {
                        case 1:
                            Console.Clear();
                            p.PersonelKayit();
                            break;
                        case 2:
                            Console.Clear();
                            p.Listele();
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Yanlış Seçimm");
                    break;

            }
            Console.ReadLine(); Console.Clear();

            Console.WriteLine("Yeni bir seçim yapmak istermisiniz");
            Console.WriteLine("1-Evet");
            Console.WriteLine("2-Hayır");

            int secimYes = int.Parse(Console.ReadLine());
            switch (secimYes)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("1-Müşteri İşlemleri");
                    Console.WriteLine("2-Personel İşlemleri");
                    int secimm = int.Parse(Console.ReadLine());
                    switch (secimm)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("1-Müşteri Kayıt");
                            Console.WriteLine("2-Para Yatırma,Çekme");
                            int secimMusteri = int.Parse(Console.ReadLine());
                            switch (secimMusteri)
                            {
                                case 1:
                                    Console.Clear();
                                    m.MusteriKayit();
                                    break;
                                case 2:
                                    Console.Clear();
                                    m.musteriIslem();
                                    break;
                            }
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("1-Personel Kayıt");
                            Console.WriteLine("2-Müşterileri Listele");
                            int secimPersonel = int.Parse(Console.ReadLine());
                            switch (secimPersonel)
                            {
                                case 1:
                                    Console.Clear();
                                    p.PersonelKayit();
                                    break;
                                case 2:
                                    Console.Clear();
                                    p.Listele();
                                    break;
                            }
                            break;
                        default:
                            Console.WriteLine("Yanlış Seçimm");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Yine Bekleriz:)");
                    break;
            }

        }

    }
}
