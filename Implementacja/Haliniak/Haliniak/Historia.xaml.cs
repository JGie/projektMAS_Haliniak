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
    /// Interaction logic for Historia.xaml
    /// </summary>
    public partial class Historia : Window
    {
        List<Zamowienie> zamowienia = new List<Zamowienie>();

        public Historia()
        {
            InitializeComponent();

            bindZamowienia();
        }

        private void bindZamowienia()
        {
            

            if (File.Exists("zamowienia.xml"))
            {
                zamowienia = zDeserializeFromXML();
                listaHistoria.ItemsSource = zamowienia;
            }
            else
            {
                listaHistoria.Visibility = Visibility.Hidden;
            }

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

        private void listViewHistoria_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            zamowienieDwaKliki();
        }
        private void zamowienieDwaKliki()
        {
            Zamowienie z = (Zamowienie)listaHistoria.SelectedItem;

            MessageBox.Show(z.info());
        }
    }

}
