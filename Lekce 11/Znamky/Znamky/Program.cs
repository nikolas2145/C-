using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znamky
{
    class Program
    {

     

        static void Main(string[] args)
        {
            // Vstup
            Console.WriteLine("Výpočet průměru známek");
            Console.WriteLine("Zadejte známky oddělené čárkou: ");
            string vstup = Console.ReadLine();
            // Rozdělení textu podle čárky na jednotlivé známky
            string[] znamky = vstup.Split(',');
            // Parsování známek
            int soucet = 0;
            foreach (string znamka in znamky)
            {
                int hodnota = int.Parse(znamka);
                soucet += hodnota;
            }
            double prumer = soucet / (double)znamky.Length;
            // Výpis
            Console.WriteLine("Průměr: {0}", prumer);
            Console.ReadKey();
        }
    }
}
