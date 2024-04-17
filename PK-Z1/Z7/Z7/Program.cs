using System;

namespace Z7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("Podaj liczbę a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbę b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\n{0}/{1} \n= {2}\nreszta: {3}", a, b, a / b, a % b);
            Console.ReadLine();
        }
    }
}
