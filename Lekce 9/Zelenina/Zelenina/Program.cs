using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zelenina
{

 

    class Program
    {
        static void Main(string[] args)
        {                      
            string[] zeleniny = { "zelí", "okurka", "rajče", "paprika", "ředkev", "mrkev", "brokolice" };
            string[] ovoce = { "jablko", "hruška", "pomeranč", "jahoda", "banán", "kiwi", "malina" };
            int slov = 0;
            string pokracovat = "ano";

            while (pokracovat == "ano")
            {
                Console.WriteLine("Zadej název libovolného ovoce nebo zeleniny: ");
                string slovo = Console.ReadLine().Trim().ToLower();

                if (ovoce.Contains(slovo))
                {
                    Console.WriteLine("Zadal jsi ovoce");
                }
                else if (zeleniny.Contains(slovo))
                {
                    Console.WriteLine("Zadal jsi zeleninu");
                }
                else
                    Console.WriteLine("Tvoje slovo nemám v seznamu");
                
                slov++;
                Console.WriteLine("Přeješ si zadat další slovo? (ano/ne)");
                pokracovat = Console.ReadLine().Trim().ToLower();
            }

            Console.WriteLine("Zadal jsi {0} slov", slov);
            Console.ReadKey();
        }
    }
}
