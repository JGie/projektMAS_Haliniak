using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haliniak.Odzież
{
    [Serializable]
    public class Klient
    {
        public string nazwa { get; set; }
        public string adres { get; set; }
        public string numerTel { get; set; }

        public Klient()
        {

        }
        public Klient(string nazwa, string adres, string numerTel)
        {
            this.nazwa = nazwa;
            this.adres = adres;
            this.numerTel = numerTel;
        }
        public override string ToString()
        {
            return "Nazwa: " + nazwa + "\nAdres: " + adres + "\nKontakt: " + numerTel;
        }
    }
}
