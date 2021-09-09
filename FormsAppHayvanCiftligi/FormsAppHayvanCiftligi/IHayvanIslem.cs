using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsAppHayvanCiftligi
{
    interface IHayvanIslem
    {
        void degerAl(int progresTDeger, int progresODeger, int progresIDeger, int progresKDeger, string tLabel, string oLabel, string iLabel, string kLabel);
        void islem();
        void check();
        void tavukYumurtaSat();
        void ordekYumurtaSat();
        void inekSutSat();
        void keciSutSat();
    }
}
