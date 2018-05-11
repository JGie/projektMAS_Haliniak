using System;

namespace Haliniak.Pracownicy
{
    [Serializable]
    public abstract class Osoba
    {
        public string pesel { get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public string adres { get; set; }
        public string numerTel { get; set; }
        public int wynagrodzenie { get; set; }
        public DateTime dataZatrudnienia { get; set; }

        public Osoba()
        {

        }

        public Osoba(string pesel1, string imie1, string nazwisko1, string adres1, string numerTel1, int wynagrodzenie1, DateTime dataZatrudnienia1)
        {
            pesel = pesel1;
            imie = imie1;
            nazwisko = nazwisko1;
            adres = adres1;
            numerTel = numerTel1;
            wynagrodzenie = wynagrodzenie1;
            dataZatrudnienia = dataZatrudnienia1;
        }
    }


}
