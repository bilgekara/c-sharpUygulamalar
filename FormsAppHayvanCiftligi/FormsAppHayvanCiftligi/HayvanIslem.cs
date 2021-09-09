using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsAppHayvanCiftligi
{
    class HayvanIslem : IHayvanIslem
    {
        public int progresTDeger; public int progresODeger; public int progresIDeger; public int progresKDeger;
        public string tLabel; public string oLabel; public string iLabel; public string kLabel;
        public int tavukPara; public int ordekPara; public int inekPara; public int keciPara;
        public int paraToplam; public string paraLabel = "0";
        public int tYumurtaAdet; public int oYumurtaAdet; public int iSutKg; public int kSutKg;
        public bool tavukYasiyo = true; public bool ordekYasiyo = true; public bool inekYasiyo = true; public bool keciYasiyo = true;
        public int SN;

        public void degerAl(int progresTDeger, int progresODeger, int progresIDeger, int progresKDeger, string tLabel, string oLabel, string iLabel, string kLabel)
        {
            this.progresTDeger = progresTDeger; this.progresODeger = progresODeger;
            this.progresIDeger = progresIDeger; this.progresKDeger = progresKDeger;
            this.tLabel = tLabel; this.oLabel = oLabel; this.iLabel = iLabel; this.kLabel = kLabel;
        }

        public void islem()
        {
            if (progresTDeger > 2)
            {
                progresTDeger -= 2;
                if (progresTDeger < 3)
                {
                    Tavuk t = new Tavuk(); t.Ses();
                    progresTDeger = 0;
                    tLabel = "ÖLDÜ";
                    tavukYasiyo = false;
                }
            }
            if (progresODeger > 3)
            {
                progresODeger -= 3;
                if (progresODeger < 4)
                {
                    Ordek o = new Ordek(); o.Ses();
                    progresODeger = 0;
                    oLabel = "ÖLDÜ";
                    ordekYasiyo = false;
                }
            }
            if (progresIDeger > 8)
            {
                progresIDeger -= 8;
                if (progresIDeger < 9)
                {
                    Inek i = new Inek(); i.Ses();
                    progresIDeger = 0;
                    iLabel = "ÖLDÜ";
                    inekYasiyo = false;
                }
            }
            if (progresKDeger > 6)
            {
                progresKDeger -= 6;
                if (progresKDeger < 7)
                {
                    Keci k = new Keci(); k.Ses();
                    progresKDeger = 0;
                    kLabel = "ÖLDÜ";
                    keciYasiyo = false;
                }
            }
        }
        public void check()
        {
            if (SN % 3 == 0) { if (tavukYasiyo) { tYumurtaAdet++; tavukPara++; } }
            if (SN % 5 == 0) { if (ordekYasiyo) { oYumurtaAdet++; ordekPara += 3; } }
            if (SN % 8 == 0) { if (inekYasiyo) { kSutKg++; keciPara += 5; } }
            if (SN % 7 == 0) { if (keciYasiyo) { iSutKg++; keciPara += 8; } }
        }
        public void tavukYumurtaSat()
        {
            tYumurtaAdet = 0;
            paraToplam += tavukPara;
            paraLabel = paraToplam.ToString();
            tavukPara = 0;
        }
        public void ordekYumurtaSat()
        {
            oYumurtaAdet = 0;
            paraToplam += ordekPara;
            paraLabel = paraToplam.ToString();
            ordekPara = 0;
        }
        public void inekSutSat()
        {
            iSutKg = 0;
            paraToplam += inekPara;
            paraLabel = paraToplam.ToString();
            inekPara = 0;
        }
        public void keciSutSat()
        {
            kSutKg = 0;
            paraToplam += keciPara;
            paraLabel = paraToplam.ToString();
            keciPara = 0;
        }

    }
}
