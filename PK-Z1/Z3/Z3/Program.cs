using System;

namespace Z3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Podaj liczbę a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a*a*a);
            Console.ReadLine();
        }
    }
}
