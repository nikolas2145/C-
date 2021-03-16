using System;

namespace sinus
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0; // Počáteční hodnota parametru x
            double y; // Proměnný pro výsledek funkce 
            char[,] mezipamet = new char[79, 24];
            // Naplnění mezipaměti samými mezerami
            for (int j = 0; j < mezipamet.GetLength(1); j++)
            {
                for (int i = 0; i < mezipamet.GetLength(0); i++)
                {
                    mezipamet[i, j] = ' ';
                }
            }
            // Zanesení bodů sinu
            while (x <= Math.PI * 2)
            {
                y = Math.Sin(x); // Výpočet hodnoty funkce
                                 // Posuneme kurzor na pozici X
                int obrazovkaX = (int)Math.Round(x * 12); // Násobíme 12, protože sinusoida má šířku 6.24 znaků a konzole má 80 znaků, chceme ji tedy asi 12x větší
                                                          // Posuneme kurzor na pozici Y
                                                          // Přičítáme 12 (polovinu výšky konzole), jelikož sinusoida jde hodnotami do mínusu, opět škálujeme tentokrát 8
                int obrazovkaY = 12 + (int)Math.Round(y * 8);
                mezipamet[obrazovkaX, obrazovkaY] = '█'; // Výpis jednoho bodu na křivce. Pokud se vám znak █ nezobrazí, nahraďte jej např. #
                x += 0.05; // Posunutí se po ose kousek dál
            }
            // Vykreslení obsahu mezipaměti do konzole
            for (int j = 0; j < mezipamet.GetLength(1); j++)
            {
                for (int i = 0; i < mezipamet.GetLength(0); i++)
                {
                    Console.Write(mezipamet[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
