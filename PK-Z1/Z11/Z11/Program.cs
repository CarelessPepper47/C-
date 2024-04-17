using System;

namespace Z11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, V, PC;
            Console.WriteLine("Podaj długość boku 1: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj długość boku 2: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj długość boku 3: ");
            c = Convert.ToDouble(Console.ReadLine());
            V = a * b * c;
            PC = 2 * (a * b + a * c + b * c);
            Console.WriteLine($"Objętość: {V}\nPole Całkowite: {PC}");
            Console.ReadLine();
        }
    }
}
