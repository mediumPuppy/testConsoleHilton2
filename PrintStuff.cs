using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace testConsoleHilton2
{
    internal class PrintStuff
    {
        private string language;
        public PrintStuff ()
        {
            language = "EN";
        }
        //constructor
        public PrintStuff(string temp)
        {
            language = temp;
        }

        public void PrintName(string name)
        {
            if (language == "EN")
            {
                System.Console.WriteLine("Hello, " + name + "!!!");
            }
            if (language == "PT")
            {
                System.Console.WriteLine("Oi, " + name + "!!!");
            }
            if (language == "DE")
            {
                System.Console.WriteLine("Hallo, " + name + "!!!");
            }
        }

    }
}
