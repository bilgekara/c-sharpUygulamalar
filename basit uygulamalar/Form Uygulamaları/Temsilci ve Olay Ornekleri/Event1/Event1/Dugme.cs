using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event1
{
    class Dugme
    {
        public event EventHandler TiklanmaOlayi;

        public void Tiklandi()
        {
            if (TiklanmaOlayi == null) return;

            TiklanmaOlayi(this, new EventArgs());
        }
    }
}
