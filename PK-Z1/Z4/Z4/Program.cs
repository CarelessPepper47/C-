using System;


namespace Z4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.Write("Podaj bok a:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj bok b:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Pole: {0}", a*b);
            Console.WriteLine("Obwód: {0}", 2 * a + 2 * b);
            Console.ReadLine();

        }
    }
}
