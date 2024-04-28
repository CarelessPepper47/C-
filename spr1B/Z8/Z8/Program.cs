using System;


namespace Z8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj bok a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj bok b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj bok c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if ((a + b > c) && (a + c > b) && (b + c > a)) { Console.WriteLine("Da się"); }
            else { Console.WriteLine("Nie da się"); }

            Console.ReadLine();
        }
    }
}
