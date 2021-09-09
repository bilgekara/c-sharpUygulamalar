using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_konsol_uygulaması_
{
    class LHarfi
    {
        public int X;
        private int genislik = 5;
        private int yükseklik = 20;
        public void goster()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkRed;

            for (int i = 0; i < yükseklik; i++)
            {
                Console.SetCursorPosition(X, 10 + i);   //koordinatı belirler
                Console.WriteLine(".");
            }
            for (int i = 0; i < genislik; i++)
            {
                Console.SetCursorPosition(X + i, 10 + yükseklik);  //koordinatı belirler
                Console.WriteLine(".");
            }
            
        }
    }
        
}
