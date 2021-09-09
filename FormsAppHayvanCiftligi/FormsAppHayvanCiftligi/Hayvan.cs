using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsAppHayvanCiftligi
{
    abstract class Hayvan
    {
        public virtual void Ses()
        {

        }
    }
    class Tavuk : Hayvan, ISes
    {
        SoundPlayer ses = new SoundPlayer();
        string dizin = Application.StartupPath + "\\ordek.wav";
        public override void Ses()
        {
            ses.SoundLocation = dizin;
            ses.Play();
        }
    }
    class Ordek : Hayvan, ISes
    {
        SoundPlayer ses = new SoundPlayer();
        string dizin = Application.StartupPath + "\\ordek.wav";
        public override void Ses()
        {
            ses.SoundLocation = dizin;
            ses.Play();
        }
    }
    class Inek : Hayvan, ISes
    {
        SoundPlayer ses = new SoundPlayer();

        string dizin = Application.StartupPath + "\\keci.wav";
        public override void Ses()
        {
            ses.SoundLocation = dizin;
            ses.Play();
        }
    }
    class Keci : Hayvan, ISes
    {
        SoundPlayer ses = new SoundPlayer();

        string dizin = Application.StartupPath + "\\inek.wav";
        public override void Ses()
        {
            ses.SoundLocation = dizin;
            ses.Play();
        }
    }
}
