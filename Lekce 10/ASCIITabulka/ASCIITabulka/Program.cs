using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIITabulka
{
    class Program
    {

    

        static void Main(string[] args)
        {
            Console.WriteLine("ASCII tabulka");
            Console.WriteLine("=============");
            for (int i = 0; i < 256; i++)
            {                
                char znak = (char)i;
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(i + ":");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(znak + "\t");
            }
            Console.ReadKey();
        }
    }
}
