using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pole10
{
    

    class Program
    {
        static void Main(string[] args)
        {
            // Inicializace
            int[] cisla = new int[10];
            // Zápis
            for (int i = 0; i < cisla.Length; i++)
            {
                cisla[i] = 10 - i;
            }
            // Výpis
            foreach (int i in cisla)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
