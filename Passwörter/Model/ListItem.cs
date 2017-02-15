using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Passwörter;


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

        public static List<ListItem> getListitems(string pAnbieter,string passw)
        {
            var items = new List<ListItem>();
            items.Add(new ListItem(pAnbieter, passw));



            return items;
        }
    }
}
