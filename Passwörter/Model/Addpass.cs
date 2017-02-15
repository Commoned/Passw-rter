using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Passwörter;
using System.IO;
using System.Reflection;

namespace Passwörter.Model
{
    class Addpass
    {
        public static void addpass(string pAnbieter, string passw)
        {
           
            try
            {
                using (FileStream fs = File.Create("Model/Afigh/" + pAnbieter + ".txt"))
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes(passw);
                    fs.Write(info, 0, info.Length);
                }
            }
            catch (Exception ex)
            {
                return;
            }
       
        }
    }
}
