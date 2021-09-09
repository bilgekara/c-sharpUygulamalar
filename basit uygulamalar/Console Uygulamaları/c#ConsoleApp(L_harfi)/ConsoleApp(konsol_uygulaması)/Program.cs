using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_konsol_uygulaması_
{
    class Program
    {
        static void Main(string[] args)
        {
            LHarfi harf = new LHarfi();
            while (true)
            {
                harf.goster();
                ConsoleKeyInfo tus = Console.ReadKey();
                if (tus.Key == ConsoleKey.D)
                {
                    harf.X++;
                }
                if (tus.Key == ConsoleKey.A)
                {
                    harf.X--;
                }
                
                harf.X = int.Parse(Console.ReadLine()); 
            }
            #region max yukseklik_genişlik
            /*Console.SetCursorPosition(10, 20);
            Console.WriteLine("genişlik....:" + Console.WindowWidth);
            Console.WriteLine("yükseklik...:" + Console.WindowHeight);*/
            #endregion
            Console.ReadKey();
        }
    }
}
