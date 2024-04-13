using System;

namespace Z5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r, h, l, V, Pc;
            Console.Write("Podaj promień: ");
            r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj wysokość: ");
            h = Convert.ToDouble(Console.ReadLine());
            l = Math.Sqrt(r*r + h*h);
            V = 1.0 / 3 * Math.PI * r * r * h;
            Pc = Math.PI * r * 2 + Math.PI * l;
            Console.WriteLine("Objętość: {0} \nPole: {1}", V, Pc);
            Console.ReadLine();
        }
    }
}
