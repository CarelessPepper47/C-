using System;

namespace Z2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string imie;
            Console.Write("Podaj swoje imie: ");
            imie = Console.ReadLine();
            Console.WriteLine("Witaj {0}", imie);
            Console.ReadLine();
        }
    }
}
