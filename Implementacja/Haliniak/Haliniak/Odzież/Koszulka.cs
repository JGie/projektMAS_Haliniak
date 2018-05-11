using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haliniak.Odzież
{
    [Serializable]
    public class Koszulka:JednostkaOdziezowa
    {
        public int numer{get;set;}
        Koszulka()
        {

        }
        public Koszulka(string nazwa1, string rozmiar1, int cena1, string dyscyplina1)
            : base(nazwa1, rozmiar1, cena1, dyscyplina1)
        {

        }
        public Koszulka(string nazwa1, string rozmiar1, int cena1, string dyscyplina1, int numer1)
            : base(nazwa1, rozmiar1, cena1, dyscyplina1)
        {
            numer = numer1;
        }

    }
}
