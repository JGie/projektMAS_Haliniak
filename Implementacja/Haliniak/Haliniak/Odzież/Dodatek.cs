using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haliniak.Odzież
{
    [Serializable]
    public class Dodatek
    {
        public string nazwa { get; set; }
        public string kolor { get; set; }

        public Dodatek()
        {

        }
        public Dodatek(string nazwa, string kolor)
        {
            this.nazwa = nazwa;
            this.kolor = kolor;
        }
    }
}
