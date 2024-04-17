using System;

namespace Z10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r, Pole, Obwód;
            Console.WriteLine("Podaj promień:");
            r = Convert.ToInt32(Console.ReadLine());
            Pole = Math.PI * r * r;
            Obwód = 2 * Math.PI * r;
            Console.WriteLine($"Pole: {Pole}\nObwód: {Obwód}");
            Console.ReadLine();
        }
    }
}
