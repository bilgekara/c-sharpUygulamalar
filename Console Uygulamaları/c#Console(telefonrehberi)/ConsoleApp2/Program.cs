using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telefon_rehberi

{

    class Program

    {

        static void Main(string[] args)

        {

            string[] isimler = new string[10];

            string[] telefonlar = new string[10];

            string[] mailler = new string[10];

            while (true)

            {

                Console.Clear();//www.gorselprogramlama.com

                Console.Write(" 1- Kayıt \n 2- Arama \n 3- Çıkış \n Seçiminiz ( 1 - 3 ) = ");

                string secim = Console.ReadLine();

                if (secim == "1")

                {

                    Console.Clear();

                    Console.WriteLine("*** Kayıt Ekranı ***");

                    Console.WriteLine("----------------------");

                    for (int i = 0; i < 3; i++)

                    {

                        Console.Write(i + 1 + ". Kişinin Adı - Soyadı = ");

                        isimler[i] = Console.ReadLine();

                        Console.Write(i + 1 + ". Kişinin Telefonu = ");

                        telefonlar[i] = Console.ReadLine();

                        Console.Write(i + 1 + ". Kişinin E Mail Adresi = ");

                        mailler[i] = Console.ReadLine();

                    }

                }

                if (secim == "2")
                {
                    do
                    {

                        Console.Clear();

                        Console.WriteLine("*** Arama Ekranı ***");

                        Console.WriteLine("----------------------");

                        Console.Write("Aranan Kişinin Adı - Soyadı = ");

                        string aranan = Console.ReadLine();

                        int sonuc = Array.IndexOf(isimler, aranan);

                        if (sonuc > 0)

                        {

                            Console.WriteLine("Aradığınız Kişinin Telefonu = " + telefonlar[sonuc]);

                            Console.WriteLine("Aradığınız Kişinin E Mail Adresi = " + mailler[sonuc]);

                        }

                        else Console.Write("Aramaya kişi bulunamadı !\n");

                        Console.Write("Aramaya Devam mı (E / H )");

                        string girilen = Console.ReadLine().ToUpper();

                        if (girilen == "H") break;
                    } while (true);
                }
                if (secim == "3") break;
            }

        }

    }

}
