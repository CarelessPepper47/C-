using System;

namespace Z3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Liczbę a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Liczbę b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Liczbę c:");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Podane liczby to: {a}, {b}, {c} ");
            if ((a == b) && (a == c))
            {
                Console.WriteLine("Wszystkie liczby są równe");
            } else 
            {
                if ((a <= b) && (a <= c))
                {
                    Console.WriteLine($"{a} jest najmniejsze");
                }
                else if ((b <= a) && (b <= c))
                {
                    Console.WriteLine($"{b} jest najmniejsze");
                }
                else
                {
                    Console.WriteLine($"{c} jest najmniejsze");
                }
                if ((a >= b) && (a >= c))
                {
                    Console.WriteLine($"{a} jest największe");
                }
                else if ((b >= a) && (b >= c))
                {
                    Console.WriteLine($"{b} jest największe");
                }
                else
                {
                    Console.WriteLine($"{c} jest największe");
                }
            }
            Console.ReadLine();
        }
    }
}
