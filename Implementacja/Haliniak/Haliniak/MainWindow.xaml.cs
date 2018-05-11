using Haliniak.Pracownicy;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace Haliniak
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Kierownik kierownik;
        Window oknoGlowne = new OknoGłówne();
        
        public MainWindow()
        {
           // stworzKierownika();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            sprawdzKierownika();

        }

        private void sprawdzKierownika()
        {
            Kierownik k = DeserializeFromXML();
            if (k.login.Equals(tboxLogin.Text) && k.haslo.Equals(pboxHaslo.Password))
            {
                oknoGlowne.Show();
                Logowanie.Close();
            }
            else
            {
                MessageBox.Show("Login lub hasło się nie zgadza ");
            }
        }

        public void stworzKierownika()
        {
             kierownik = new Kierownik("k1", "k1", "92041300016", "Jakub", "Gie", "WWa", "777", 1000, new DateTime(2010, 01, 01));
             SerializeToXML(kierownik);
        }

        static public void SerializeToXML(Kierownik kierownik)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Kierownik));
            TextWriter textWriter = new StreamWriter(@"kierownik.xml");
            serializer.Serialize(textWriter, kierownik);
            textWriter.Close();
        }

        static Kierownik DeserializeFromXML()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(Kierownik));
            TextReader textReader = new StreamReader(@"kierownik.xml");
            Kierownik kierownik;
            kierownik = (Kierownik)deserializer.Deserialize(textReader);
            textReader.Close();

            return kierownik;
        }



    }
}
