using Haliniak.Odzież;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace Haliniak
{
    /// <summary>
    /// Interaction logic for Dostepnosc.xaml
    /// </summary>
    public partial class Dostepnosc : Window
    {
        List<Zamowienie> wszystkieZamowienia = new List<Zamowienie>();
        Zamowienie globalZamowienie;

        public Dostepnosc(Zamowienie zamowienie)
        {
            InitializeComponent();
            globalZamowienie = zamowienie;
            sprawdzZamowienie(zamowienie);
        }

        private void sprawdzZamowienie(Zamowienie zamowienie)
        {
            List<JednostkaOdziezowa> magazyn = DeserializeFromXML();
            daneKlienta.Content = zamowienie.klient.ToString();
            List<JednostkaOdziezowa> kopiaZ = zamowienie.listaOdziezy.ToList();

            foreach (JednostkaOdziezowa jo in kopiaZ.ToArray())
            {
                foreach (JednostkaOdziezowa jom in magazyn.ToArray())
                {
                    if (jo.nazwa.Equals(jom.nazwa))
                    {
                        kopiaZ.Remove(jo);
                        magazyn.Remove(jom);
                    }
                }
            }


            if (kopiaZ.Count == 0)
            {
                zamowienieDostepne();
            }
            else
            {
                zamowienieNiedostepne();
            }
        }

        private void zamowienieNiedostepne()
        {
            lblNiedostepne.Visibility = Visibility.Visible;
            btnPrzyjmij.IsEnabled = false;
        }

        private void zamowienieDostepne()
        {
            lblDostepne.Visibility = Visibility.Visible;
        }

        static List<JednostkaOdziezowa> DeserializeFromXML()
        {
            Type[] joTypes = { typeof(JednostkaOdziezowa), typeof(Koszulka), typeof(Spodnie), typeof(Bluza) };
            XmlSerializer deserializer = new XmlSerializer(typeof(List<JednostkaOdziezowa>), joTypes);
            TextReader textReader = new StreamReader(@"magazyn.xml");
            List<JednostkaOdziezowa> magazyn;
            magazyn = (List<JednostkaOdziezowa>)deserializer.Deserialize(textReader);
            textReader.Close();

            return magazyn;
        }
        static List<Zamowienie> zDeserializeFromXML()
        {
            Type[] joTypes = { typeof(JednostkaOdziezowa),typeof(Klient), typeof(Koszulka), typeof(Spodnie), typeof(Bluza) };
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Zamowienie>), joTypes);
            TextReader textReader = new StreamReader(@"zamowienia.xml");
            List<Zamowienie> zamowienia = new List<Zamowienie>();
            zamowienia = (List<Zamowienie>)deserializer.Deserialize(textReader);
            textReader.Close();

            return zamowienia;
        }

        static public void SerializeToXML(List<Zamowienie> z)
        {
            Type[] types = { typeof(JednostkaOdziezowa),typeof(Zamowienie), typeof(Klient), typeof(Koszulka), typeof(Spodnie), typeof(Bluza) };
            XmlSerializer serializer = new XmlSerializer(typeof(List<Zamowienie>), types);
            TextWriter textWriter = new StreamWriter(@"zamowienia.xml");
            serializer.Serialize(textWriter, z);
            textWriter.Close();
        }

        private void listVZamowienia_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnPrzyjmij_Click(object sender, RoutedEventArgs e)
        {
            przyjmijZamowienie();
            aktualizujOknoNoweZamowienia();
            this.Close();

        }

        private void btnOdrzuc_Click(object sender, RoutedEventArgs e)
        {
            odrzucZamowienie();
            aktualizujOknoNoweZamowienia();
            this.Close();
        }

        private void aktualizujOknoNoweZamowienia()
        {
            ((OknoNoweZamówienia)this.Owner).listaZamowien.Remove(globalZamowienie);
            ((OknoNoweZamówienia)this.Owner).listBoxZamowienia.Items.Refresh();
        }

        private void odrzucZamowienie()
        {
            globalZamowienie.status = "Odrzucone";

            if (File.Exists("zamowienia.xml"))
            {
                wszystkieZamowienia = zDeserializeFromXML();
            }
            wszystkieZamowienia.Add(globalZamowienie);
            SerializeToXML(wszystkieZamowienia);
        }

        private void przyjmijZamowienie()
        {

            globalZamowienie.status = "Przyjęte";

            if (File.Exists("zamowienia.xml"))
            {
                wszystkieZamowienia = zDeserializeFromXML();
            }
            wszystkieZamowienia.Add(globalZamowienie);
            SerializeToXML(wszystkieZamowienia);

        }
    }
}
