using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBicimsel
{
    class Program
    {
        static void Main(string[] args)
        {
            string durum = "A";
            string katar = Console.ReadLine();
            bool finalState = false; ;
            for(int i = 0; i < katar.Length; i++)
            {
                if (durum == "A")
                {
                    finalState = true;
                    if (katar[i] == 'a') durum = "B";
                    else durum = "dead";
                }
                else if (durum == "B")
                {
                    finalState = true;
                    if (katar[i] == 'a') durum = "C";
                    else durum = "E";
                }
                else if (durum == "C")
                {
                    finalState = true;
                    if (katar[i] == 'a') durum = "C";
                    else durum = "D";
                }
                else if (durum == "D")
                {
                    finalState = true;
                    if (katar[i] == 'a') durum = "B";
                    else durum = "dead";
                }
                else if (durum == "E")
                {
                    if (katar[i] == 'a') durum = "F";
                    else durum = "dead";
                }
                else if (durum == "F")
                {
                    finalState = true;
                    if (katar[i] == 'a') durum = "B";
                    else durum = "dead";
                }

            }
            if (finalState)
            {
                Console.WriteLine("Girilen ifade dil tarafından kabul edildi.");
            }
            else
            {
                Console.WriteLine("Girilen ifade dil ile eşleşmemektedir.");
            }
            Console.ReadKey();
        }
    }
}
