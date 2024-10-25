using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10 i++) ;
                Console.WriteLine("Kérném a személyazonosító 10 jegyét!");
            string Szemszam = Console.ReadLine();
            var nem = Szemszam[0];
            if (nem == 1 || nem == 3)
            {
                Console.WriteLine("A személy férfi");
            }
            else
            {
                Console.WriteLine("Helytelen azonosító");
            }
            string szulszam = Szemszam.Substring(7, 3);
            Console.WriteLine($"Születési sorszáma: {szulszam}");
        } 
    }
}
