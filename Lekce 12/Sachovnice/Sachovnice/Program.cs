using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sachovnice
{
    
    class Program
    {
        static void Main(string[] args)
        {
            for (int j = 0; j < 8; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    if ((i + j) % 2 == 0)
                        Console.Write("██");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine(); // Odřádkování
            }
            Console.ReadKey();
        }
    }
}
