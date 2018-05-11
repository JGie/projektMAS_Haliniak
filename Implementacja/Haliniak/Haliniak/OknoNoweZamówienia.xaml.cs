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
    /// Interaction logic for OknoNoweZamówienia.xaml
    /// </summary>
    public partial class OknoNoweZamówienia : Window
    {
        Window wDostepnosc;

        public List<Klient> listaKlientow = new List<Klient>();
        public List<Zamowienie> listaZamowien = new List<Zamowienie>();
        public List<JednostkaOdziezowa> listaProduktow = new List<JednostkaOdziezowa>();


        public OknoNoweZamówienia()
        {

            stworzDane();
            InitializeComponent();

            zamowieniaBind();
        }



        private void zamowieniaBind()
        {

            listBoxZamowienia.ItemsSource = listaZamowien;
        }

        /// <summary>
        /// tworzymy przykladowe dane
        /// </summary>
        private void stworzDane()
        {
            //Klient
            Klient k1 = new Klient("Klient1", "Kraków", "111-222-333");
            Klient k2 = new Klient("Klient2", "Warszawa", "222-333-444");
            Klient k3 = new Klient("Klient3", "Wrocław", "333-444-555");

            //Odziez
            Koszulka ko1 = new Koszulka("Koszulka1", "M", 100, "jogging");
            Koszulka ko2 = new Koszulka("Koszulka2", "L", 100, "piłka nożna", 13);
            Koszulka ko3 = new Koszulka("Koszulka3", "XL", 100, "piłka nożna", 10);

            Spodnie s1 = new Spodnie("Spodnie1", "XL", 150, "jogging", 80);
            Spodnie s2 = new Spodnie("Spodnie2", "XXL", 150, "narciarstwo", 100);

            Bluza b1 = new Bluza("Bluza1", "XL", 150, "Golf", false);

            //listaProduktow.Add(ko1);
            //listaProduktow.Add(ko2);
            //listaProduktow.Add(ko3);
            //listaProduktow.Add(s1);
            //listaProduktow.Add(s2);

            //   SerializeToXML(listaProduktow);



            //Zamowienie
            List<JednostkaOdziezowa> ciuchyDoZ1 = new List<JednostkaOdziezowa>();
            List<JednostkaOdziezowa> ciuchyDoZ2 = new List<JednostkaOdziezowa>();
            List<JednostkaOdziezowa> ciuchyDoZ3 = new List<JednostkaOdziezowa>();
            ciuchyDoZ1.Add(s1);
            ciuchyDoZ1.Add(ko2);
            ciuchyDoZ1.Add(ko2);

            ciuchyDoZ2.Add(ko1);
            ciuchyDoZ2.Add(ko2);
            ciuchyDoZ2.Add(ko3);
            ciuchyDoZ2.Add(s2);

            ciuchyDoZ3.Add(b1);

            Zamowienie z1 = new Zamowienie(k1, "odbiór osobisty", "Oczekujące", new DateTime(2015, 06, 16), ciuchyDoZ1);
            Zamowienie z2 = new Zamowienie(k2, "za pobraniem", "Oczekujące", new DateTime(2015, 06, 17), ciuchyDoZ2);
            Zamowienie z3 = new Zamowienie(k3, "za pobraniem", "Oczekujące", new DateTime(2015, 06, 18), ciuchyDoZ3);


            listaZamowien.Add(z1);
            listaZamowien.Add(z2);
            listaZamowien.Add(z3);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Rozpatrz_Click(object sender, RoutedEventArgs e)
        {
            rozpatrzZamowienie();

        }

        private void rozpatrzZamowienie()
        {
            if (listBoxZamowienia.SelectedItem != null)
            {
                Zamowienie z = (Zamowienie)listBoxZamowienia.SelectedItem;
                z.status = "Rozpatrywane";
                wDostepnosc = new Dostepnosc(z);
                wDostepnosc.Owner = this;
                wDostepnosc.Show();
            }
            else
            {
                MessageBox.Show("Zaznacz zamówienie");
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void listBoxZamowienia_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            zamowienieZmienione();

        }

        private void zamowienieZmienione()
        {
            Zamowienie z = (Zamowienie)listBoxZamowienia.SelectedItem;
            listViewProdukty.Items.Clear();
            if (z != null)
            {
                foreach (JednostkaOdziezowa jo in z.listaOdziezy)
                {
                    listViewProdukty.Items.Add(jo);
                }

                listViewProdukty.Items.Refresh();
            }

        }

        private void listBoxZamowienia_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            zamowienieDwaKliki();


        }

        private void zamowienieDwaKliki()
        {
            Zamowienie z = (Zamowienie)listBoxZamowienia.SelectedItem;

            MessageBox.Show(z.info());
        }

        static public void SerializeToXML(List<JednostkaOdziezowa> jo)
        {
            Type[] joTypes = { typeof(JednostkaOdziezowa), typeof(Koszulka), typeof(Spodnie), typeof(Bluza) };
            XmlSerializer serializer = new XmlSerializer(typeof(List<JednostkaOdziezowa>), joTypes);
            TextWriter textWriter = new StreamWriter(@"magazyn.xml");
            serializer.Serialize(textWriter, jo);
            textWriter.Close();
        }

        private void btnAnuluj_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Closed(object sender, EventArgs e)
        {

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }

        private void btnWroc_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            aktualizujMagazyn();

        }

        private void aktualizujMagazyn()
        {
            List<Zamowienie> zamowienia = zDeserializeFromXML();
            List<JednostkaOdziezowa> magazyn = DeserializeFromXML();
            List<JednostkaOdziezowa> listaOdziezy=new List<JednostkaOdziezowa>();

            foreach (Zamowienie z in zamowienia)
            {
                if(z.status.Equals("Przyjęte"))
                {
                    foreach (JednostkaOdziezowa jo in z.listaOdziezy)
                    {
                        listaOdziezy.Add(jo);
                    }
                }
            }

            foreach (JednostkaOdziezowa jom in magazyn.ToList())
            {
                foreach (JednostkaOdziezowa jo in listaOdziezy.ToList())
                {
                    if (jom.nazwa.Equals(jo.nazwa))
                    {
                        magazyn.Remove(jom);
                    }
                }
            }

            SerializeToXML(magazyn);
            

        }

        static List<Zamowienie> zDeserializeFromXML()
        {
            Type[] joTypes = { typeof(JednostkaOdziezowa), typeof(Koszulka), typeof(Spodnie), typeof(Bluza) };
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Zamowienie>), joTypes);
            TextReader textReader = new StreamReader(@"zamowienia.xml");
            List<Zamowienie> zamowienia = new List<Zamowienie>();
            zamowienia = (List<Zamowienie>)deserializer.Deserialize(textReader);
            textReader.Close();

            return zamowienia;
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

    }
}
