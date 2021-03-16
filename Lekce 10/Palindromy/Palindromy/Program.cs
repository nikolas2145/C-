using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromy
{
    class Program
    {
       

        static void Main(string[] args)
        {
            // Zadání vstupu
            Console.WriteLine("Zadej palindrom: ");
            string palindrom = Console.ReadLine();
            // Získání řetězce pozpátku
            string pozpatku = "";
            for (int i = palindrom.Length - 1; i >= 0; i--)
            {
                pozpatku += palindrom[i];
            }
            // Porovnání
            if (palindrom == pozpatku)
                Console.WriteLine("Ano, toto je palindrom.");
            else
                Console.WriteLine("Toto není palindrom.");
            Console.ReadKey();
        }
    }
}
