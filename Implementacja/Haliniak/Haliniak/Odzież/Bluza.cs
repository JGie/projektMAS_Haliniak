using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haliniak.Odzież
{   
    [Serializable]
    public class Bluza : JednostkaOdziezowa
    {
        public bool czyZkapturem { get; set; }

        public Bluza()
        {

        }
        public Bluza(string nazwa1, string rozmiar1, int cena1, string dyscyplina1,bool czyZkapturem1)
            : base(nazwa1, rozmiar1, cena1, dyscyplina1)
        {
            czyZkapturem = czyZkapturem1;
        }
    }
}
