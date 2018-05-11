using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haliniak.Pracownicy
{
    [Serializable]
    public class Kierownik : Osoba
    {
        public string login {  get;  set; }
        public string haslo {  get;  set; }

        public Kierownik()
        {

        }

        public Kierownik(string login1, string haslo1, string pesel1, string imie1, string nazwisko1, string adres1, string numerTel1, int wynagrodzenie1, DateTime dataZatrudnienia1)
            : base(pesel1, imie1, nazwisko1, adres1, numerTel1, wynagrodzenie1, dataZatrudnienia1)
        {
            login = login1;
            haslo = haslo1;

        }
    }
}
