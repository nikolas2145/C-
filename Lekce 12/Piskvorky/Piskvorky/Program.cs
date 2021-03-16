using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piskvorky
{
   
    class Program
    {
        static void Main(string[] args)
        {            
            int hrac = 2; // Počáteční hráč
            bool konec = false; // Zda již nastal konec hry
            int[,] plocha = new int[9, 9]; // Hrací plocha
            string[] znaky = { " ", "O", "X" }; // Znaky kamenů (prázdno, kolečko, křížek)
            string[] hraci = { "nikdo", "hráč s kolečky", "hráč s křížky" }; // Názvy hráčů
            
            // Herní smyčka
            while (!konec)
            {                
                // Vykreslení
                // ===================================================
                Console.Clear(); // Vymažeme konzoli
                // První řádek s vodorovnými souřadnicemi
                Console.Write("  ");
                for (int i = 0; i < plocha.GetLength(0); i++)
                {
                    Console.Write(i + 1);
                }
                Console.WriteLine();
                // Vykreslení hrací plochy
                for (int j = 0; j < plocha.GetLength(1); j++)
                {
                    // Číslo na začátku řádku
                    Console.Write("{0} ", j + 1);
                    for (int i = 0; i < plocha.GetLength(0); i++)
                    {
                        int znak = plocha[i, j];
                        Console.Write(znaky[znak]);
                    }
                    Console.WriteLine();
                }

                // Vyhodnocení výhry
                // ===================================================
                int symboluVyhra = 5;
                // Hledání 5ti stejných symbolů hráče
                int zaplneno = 0; // Počet zaplněných polí
                int symboluRadek = 0; // Počet stejných symbolů za sebou v řádku
                int symboluSloupec = 0; // Počet stejných symbolů za sebou ve sloupci

                // 2 vnořené cykly postupně projedou všechna políčka v hrací ploše, tato kontrola je docela jednoduchá
                for (int j = 0; j < plocha.GetLength(1); j++)
                {
                    for (int i = 0; i < plocha.GetLength(0); i++)
                    {
                        // Kontrola zaplnění
                        if (plocha[i, j] > 0)
                            zaplneno++;
                        if (zaplneno == plocha.Length)
                        {
                            Console.WriteLine("Remíza.");
                            konec = true;
                        }
                        // Počítání souvislých symbolů posledního hráče na tahu v řádku
                        if (plocha[i, j] == hrac)
                            symboluRadek++;
                        else // Symbol nebyl nalezen, vynulujeme počítadlo nepřerušené řady symbolů
                            symboluRadek = 0;

                        // Počítání souvislých symbolů posledního hráče na tahu ve sloupci
                        if (plocha[j, i] == hrac)
                            symboluSloupec++;
                        else // Symbol nebyl nalezen, vynulujeme počítadlo nepřerušeného sloupce symbolů
                            symboluSloupec = 0;
                        // Vyhodnocení výhry řadou nebo sloupcem
                        if (symboluRadek == symboluVyhra || symboluSloupec == symboluVyhra)
                        {
                            Console.WriteLine("Vyhrál {0}", hraci[hrac]);
                            konec = true;
                        }
                       
                    }
                }
                // Diagonály - tady je to horší :)
                int symboluDiagonalaLeva = 0; // Počet stejných symbolů za sebou v diagonále zleva doprava
                int symboluDiagonalaPrava = 0; // Počet stejných symbolů za sebou v diagonále zprava doleva

                // 2 vnořené cykly postupně projedou všechny diagonály
                for (int j = 0; j < plocha.GetLength(1) * 2; j++) // Projíždíme 2x více řad než má hrací plocha, jinak bychom nalezli jen polovinu diagonál
                {
                    for (int i = 0; i < plocha.GetLength(0); i++)
                    {
                        // Diagonála zprava doleva
                        int dy = plocha.GetLength(1) - 1 - j + i; // Postupujeme od posledního řádku nahoru
                        if (dy >= 0 && dy < plocha.GetLength(1) && (plocha[plocha.GetLength(0) - 1 - i, dy] == hrac)) // Nevyjeli jsme z plochy a našli jsme hráčův kámen
                            symboluDiagonalaLeva++;
                        else
                            symboluDiagonalaLeva = 0; // Jsme mimo nebo tam hráč nemá kámen

                        // Diagonála zleva doprava
                        if (dy >= 0 && dy < plocha.GetLength(1) && (plocha[i, dy] == hrac)) // Nevyjeli jsme z plochy a našli jsme hráčův kámen
                            symboluDiagonalaPrava++;
                        else
                            symboluDiagonalaPrava = 0; // Jsme mimo nebo tam hráč nemá kámen
                        // Vyhodnocení výhry jednou z diagonál
                        if (symboluDiagonalaLeva == symboluVyhra || symboluDiagonalaPrava == symboluVyhra)
                        {
                            Console.WriteLine("Vyhrál {0}", hraci[hrac]);
                            konec = true;
                        }
                    }
                }
                // Přidání kamenu hráče
                // ===================================================
                if (!konec)
                {
                    // Prohození hráčů
                    if (hrac == 1)
                        hrac = 2;
                    else
                        hrac = 1;
                    Console.WriteLine("\nNa řadě je {0}", hraci[hrac]);                    
                    bool volno = false;
                    int x = 1;
                    int y = 1;
                    // Načítání souřadnic dokud nezadá takové, kde je volno
                    while (!volno)
                    {
                        Console.Write("Zadej pozici X kam chceš tahnout: ");
                        while (!int.TryParse(Console.ReadLine(), out x))
                            Console.WriteLine("Zadej prosím celé číslo");
                        Console.Write("Zadej pozici Y kam chceš tahnout: ");
                        while (!int.TryParse(Console.ReadLine(), out y))
                            Console.WriteLine("Zadej prosím celé číslo");
                        if (x >= 1 && y >= 1 && x <= 9 && y <= 9 && plocha[x - 1, y - 1] == 0) // Souřadnice jsou v hrací ploše a není tam hráčův kámen
                            volno = true;
                        else
                            Console.WriteLine("Neplatná pozice, zadej ji prosím znovu.");
                    }
                    plocha[x - 1, y - 1] = hrac; // Uložení kamene hráče do hrací plochy
                }
                
            }
            Console.ReadKey();
        }
    }
}
