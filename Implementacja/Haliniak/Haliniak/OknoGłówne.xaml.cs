using System;
using System.Collections.Generic;
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

namespace Haliniak
{
    /// <summary>
    /// Interaction logic for OknoGłówne.xaml
    /// </summary>
    public partial class OknoGłówne : Window
    {
        Window oknoNoweZamowienia= new OknoNoweZamówienia();
        Window historia;
        public OknoGłówne()
        {
            InitializeComponent();
        }

        private void btnZamowienia_Click(object sender, RoutedEventArgs e)
        {
           otworzOknoZamowien();
        }

        private void otworzOknoZamowien()
        {

            oknoNoweZamowienia.Show();
        }

        private void btnRozpatrzone_Click(object sender, RoutedEventArgs e)
        {
            historia = new Historia();
            historia.Show();

        }
    }
}
