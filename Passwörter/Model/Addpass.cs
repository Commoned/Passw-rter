using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Passwörter;
using System.IO;
using System.Reflection;
using System.Collections;

namespace Passwörter.Model
{
    class Addpass
    {
        public static async void addpass(string pAnbieter, string passw)
        {
            byte[] bytesToWrite = Encoding.Unicode.GetBytes(passw);
            using (FileStream createdFile = File.Create("Model/Afigh/" + pAnbieter + ".txt", 4096, FileOptions.Asynchronous))
            {
                await createdFile.WriteAsync(bytesToWrite, 0, bytesToWrite.Length);
            }


            /*File.Create("Model/Afigh/" + pAnbieter + ".txt", 1, FileOptions.Asynchronous);
                
            File.SetAttributes("Model/Afigh/" + pAnbieter + ".txt",FileAttributes.Normal);
            IEnumerable<string> m_oEnum = new string[] {passw};
            File.WriteAllLines("Model/Afigh/" + pAnbieter + ".txt",m_oEnum);*/

        }
    }
}
