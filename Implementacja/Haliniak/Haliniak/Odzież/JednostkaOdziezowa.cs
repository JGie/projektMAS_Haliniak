using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haliniak.Odzież
{
    [Serializable]
    public abstract class JednostkaOdziezowa
    {
        public string nazwa { get; set; }
        public string rozmiar { get; set; }
        public int cena { get; set; }
        public string dyscyplina { get; set; }

        public JednostkaOdziezowa()
        {

        }

        public JednostkaOdziezowa(string nazwa1, string rozmiar1, int cena1, string dyscyplina1)
        {
            nazwa = nazwa1;
            rozmiar = rozmiar1;
            cena = cena1;
            dyscyplina = dyscyplina1;
        }

        public override string ToString()
        {
            return this.nazwa.ToString();
        }
    
    }


}
