using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morzeovka
{
    class Program
    {
      

        static void Main(string[] args)
        {
            // Řetězec, který chceme dekódovat
            Console.WriteLine("Zadejte zprávu k zakódování: ");
            string zprava = Console.ReadLine().ToLower();
            string zakodovana = "";
            // vzorová pole
            string abecedniZnaky = "abcdefghijklmnopqrstuvwxyz";
            string[] morseovyZnaky = {".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....",
                                      "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-",
                                      "...-", ".--", "-..-", "-.--", "--.."};
            // Přeložení jednotlivých znaků
            foreach (char znak in zprava)
            {
                int pozice = abecedniZnaky.IndexOf(znak);
                if (pozice >= 0)
                    zakodovana += morseovyZnaky[pozice] + " ";
            }
            // Výpis
            Console.WriteLine("Zakódovaná zpráva: {0}", zakodovana);
            Console.ReadKey();
        }
    }
}
