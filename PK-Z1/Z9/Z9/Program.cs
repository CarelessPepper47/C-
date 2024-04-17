using System;


namespace Z9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, sumaKwa;
            Console.WriteLine("Podaj liczbę a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbę b:");
            b = Convert.ToInt32(Console.ReadLine());
            sumaKwa = a*a + b*b;
            Console.WriteLine($"Suma kwadratów tych liczb to: {sumaKwa}");
            Console.ReadLine();
        }
    }
}
