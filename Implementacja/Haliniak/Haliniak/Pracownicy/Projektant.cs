using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haliniak.Pracownicy
{
    [Serializable]
    public class Projektant:Osoba
    {
        public string styl { get ;set;}
        public Projektant(string pesel1, string imie1, string nazwisko1, string adres1, string numerTel1, int wynagrodzenie1, DateTime dataZatrudnienia1, string styl1)
            : base(pesel1, imie1, nazwisko1, adres1, numerTel1, wynagrodzenie1, dataZatrudnienia1)
        {
            styl = styl1;
        }
    }
}
