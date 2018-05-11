using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haliniak.Odzież
{
    [Serializable]
    public class Spodnie : JednostkaOdziezowa
    {
        public int dlugosc { get; set; }

        public Spodnie()
        {

        }
        public Spodnie(string nazwa1, string rozmiar1, int cena1, string dyscyplina1, int dlugosc1)
            : base(nazwa1, rozmiar1, cena1, dyscyplina1)
        {
            dlugosc = dlugosc1;
        }


    }
}
