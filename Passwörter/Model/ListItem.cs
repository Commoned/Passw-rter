using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Passwörter;
using System.Collections.ObjectModel;
using System.IO;

namespace Passwörter.Model
{
    public class ListItem
    {
        public string Anbieter { get; set; }
        public string Passwort { get; set; }
        

        public ListItem(string anbieter, string passwort)
        {
            Anbieter = anbieter;
            Passwort = passwort;
            
            
    }
        public static void GetAllItems(ObservableCollection<ListItem> items)
        {
            var allitems = getListitems();
            items.Clear();
            allitems.ForEach(p => items.Add(p));
        }

        private static List<ListItem> getListitems()
        {
            var items = new List<ListItem>();

            string[]  dank = Directory.GetFiles("Model/Afigh").Select(file =>
            Path.GetFileNameWithoutExtension(file)).ToArray();
            foreach(string fileName in dank)
            {
                string aids = System.IO.File.ReadAllLines("Model/Afigh/" + fileName + ".txt").ToString();
                items.Add(new ListItem(fileName,aids));
            }


            return items;
        }
    }
}
