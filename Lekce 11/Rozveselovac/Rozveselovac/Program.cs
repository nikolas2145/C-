using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozveselovac
{
    class Program
    {
        

        static void Main(string[] args)
        {
            // Načtení vstupu
            Console.WriteLine("Zadej text k rozveselení: ");
            string text = Console.ReadLine();
            // Pomocná pole
            char[] interpunkce = {'!', '?', '.'};
            string[] smajlici = {":)", ":D", ":P"};
            // Čtení věty
            int pozice = 0;
            int smajlik = 0;
            while (pozice < text.Length)
            { 
                // narazilo se na interpunkci
                if (interpunkce.Contains(text[pozice]))
                {
                    // Odstranění tečky
                    if (text[pozice] == '.')
                    {
                        text = text.Remove(pozice, 1);
                        pozice--;
                    }
                    // Vložení smajlíku
                    text = text.Insert(pozice + 1, " " + smajlici[smajlik]);
                    pozice++;
                    // Úprava pozice příštího smajlíku
                    smajlik++;
                    if (smajlik > smajlici.Length - 1)
                        smajlik = 0;
                }
                pozice++;
            }
            // Výpis
            Console.WriteLine("Rozveselený text: {0}", text);
            Console.ReadKey();
        }
    }
}
