using System;

namespace Z1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Podaj liczbę całkowitą");
            a = Convert.ToInt32(Console.ReadLine());
            if (a%2 == 0)
            {
                Console.WriteLine($"Liczba {a} jest parzysta");
            } else
            {
                Console.WriteLine($"Liczba {a} jest nieparzysta");
            }
            Console.ReadLine();
        }
    }
}
