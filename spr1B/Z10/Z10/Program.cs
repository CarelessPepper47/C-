using System;

namespace Z10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę arabską od 1 do 1 000 000:");
            int liczba = Convert.ToInt32(Console.ReadLine());

            if (liczba < 1 || liczba > 1000000)
            {
                Console.WriteLine("Liczba spoza zakresu.");
                return;
            }

            if (liczba == 1000000) { Console.WriteLine("milion"); }

            int tysiace = liczba / 1000;
            int reszta = liczba % 1000;

            int setki_tys = tysiace / 100;
            int dziesiatki_tys = (tysiace / 10) % 10;
            int jednosci_tys = tysiace % 10;

            int setki_reszta = reszta / 100;
            int dziesiatki_reszta = (reszta / 10) % 10;
            int jednosci_reszta = reszta % 10;

            string[] jednosci = { "", "jeden", "dwa", "trzy", "cztery", "pięć", "sześć", "siedem", "osiem", "dziewięć" };
            string[] dziesiatki = { "", "dziesięć", "dwadzieścia", "trzydzieści", "czterdzieści", "pięćdziesiąt", "sześćdziesiąt", "siedemdziesiąt", "osiemdziesiąt", "dziewięćdziesiąt" };
            string[] setki = { "", "sto", "dwieście", "trzysta", "czterysta", "pięćset", "sześćset", "siedemset", "osiemset", "dziewięćset" };
            string[] tys = { "", "tysiąc", "tysiące", "tysięcy" };

            if (setki_tys > 0)
            {
                Console.Write(setki[setki_tys] + " ");
            }
            if (dziesiatki_tys == 1)
            {
                Console.Write(dziesiatki[dziesiatki_tys] + " ");
            }
            else if (dziesiatki_tys > 1)
            {
                Console.Write(dziesiatki[dziesiatki_tys] + " ");
                Console.Write(jednosci[jednosci_tys] + " ");
            }

            if (jednosci_tys == 1 && dziesiatki_tys != 1 && setki_tys == 0)
            {
                Console.Write(tys[1] + " ");
            }
            else if ((jednosci_tys > 1 && jednosci_tys < 5) || (jednosci_tys == 0 && dziesiatki_tys == 0))
            {
                Console.Write(tys[2] + " ");
            }
            else if (jednosci_tys >= 5 || jednosci_tys == 0)
            {
                Console.Write(tys[3] + " ");
            }

            if (reszta > 0)
            {

                if (setki_reszta > 0)
                {
                    Console.Write(setki[setki_reszta] + " ");
                }
                if (dziesiatki_reszta == 1)
                {
                    Console.Write(dziesiatki[dziesiatki_reszta] + " ");
                }
                else if (dziesiatki_reszta > 1)
                {
                    Console.Write(dziesiatki[dziesiatki_reszta] + " ");
                }

                if (jednosci_reszta == 1 && dziesiatki_reszta != 1)
                {
                    Console.Write("jeden ");
                }
                else if (jednosci_reszta > 1)
                {
                    Console.Write(jednosci[jednosci_reszta] + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
