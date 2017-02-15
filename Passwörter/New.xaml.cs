using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Security.Cryptography;
using Passwörter.Model;
using System.Collections.ObjectModel;

// Die Elementvorlage "Leere Seite" wird unter https://go.microsoft.com/fwlink/?LinkId=234238 dokumentiert.

namespace Passwörter
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class New : Page
    {
        public double x;
        private ObservableCollection<ListItem> ListItems;
        public New()
        {
            this.InitializeComponent();
           

}

        private void neues_Click(object sender, RoutedEventArgs e)
        {

        }

        private void generate_Click(object sender, RoutedEventArgs e)
        {
            string pass;
            string pAnbieter = anbieter.Text;
            x = pLaenge.Value;
            pass = passgen.CreatePassword(x);
            passw.Text = pass;
           // ListItem.getListitems(pAnbieter,pass);
            Addpass.addpass(pAnbieter, pass);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null);
        }

        private void Einstellungen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void pLaenge_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
           
        }
    }
}
