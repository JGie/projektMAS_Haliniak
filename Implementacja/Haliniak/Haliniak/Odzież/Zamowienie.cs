using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haliniak.Odzież
{
    [Serializable]
    public class Zamowienie
    {
        public string opis { get; set; }
        public string status { get; set; }
        public DateTime data { get; set; }
        public int cena { get; set; }
        public List<JednostkaOdziezowa> listaOdziezy { get; set; }
        public Klient klient { set; get; }

        public Zamowienie()
        {

        }
        public Zamowienie(Klient klient, string opis,string status, DateTime data,List<JednostkaOdziezowa> listaOdziezy)
        {
            this.klient = klient;
            this.opis = opis;
            this.status = status;
            this.data = data;
            this.listaOdziezy = listaOdziezy;
            this.cena = wyliczCene();
        }
        

        private int wyliczCene()
        {
            int cena = 0;
            foreach (JednostkaOdziezowa jo in listaOdziezy)
            {
                cena = cena + jo.cena;
            }
            return cena;
        }

        public override string ToString()
        {
            return this.data.ToShortDateString()+" "+status;
        }

        public string info()
        {
            return "Data zamówienia: " + data.ToShortDateString() + "\nKlient: " + klient.nazwa + "\nOpis: " + opis + "\nStatus: " + status +"\nCena: "+cena;
        }

        public string infoH()
        {
            return "Data zamówienia: " + data.ToShortDateString() + "; Klient: " + klient.nazwa + "; Opis: " + opis + "; Status: " + status + "; Cena: " + cena;
        }
    }
}
