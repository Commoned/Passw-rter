using Passwörter.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// Die Elementvorlage "Leere Seite" wird unter https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x407 dokumentiert.

namespace Passwörter
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<ListItem> ListItems;
        public MainPage()
        {
            this.InitializeComponent();
            ListItems = new ObservableCollection<ListItem>();
            ListItem.GetAllItems(ListItems);
        }

        private void Einstellungen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Search_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {

        }

        private void Search_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {

        }

        private void List_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void neu_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(New), null);
        }

        private void delmode_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
