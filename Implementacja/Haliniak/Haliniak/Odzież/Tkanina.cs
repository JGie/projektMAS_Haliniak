using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haliniak.Odzież
{
    [Serializable]
    public class Tkanina
    {
        public List<string> surowce;
        public string kolor { get; set; }
        public string ocenaJakosci { get; set; }

        public Tkanina()
        {

        }
        public Tkanina(List<string> surowce1, string kolor1, string ocenaJakosci1)
        {
            surowce = surowce1;
            kolor = kolor1;
            ocenaJakosci = ocenaJakosci1;
        }
    }

    
}
