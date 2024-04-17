using System;

namespace Z2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Podaj liczbę: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine($"{a} jest dodatnie");
            } else if (a < 0)
            {
                Console.WriteLine($"{a} jest ujemne");
            } else
            {
                Console.WriteLine($"0");
            }
            Console.ReadLine();
        }
    }
}
