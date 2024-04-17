using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max, min;
            Console.WriteLine("Podaj liczbę a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbę b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbę c:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbę d:");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbę e:");
            int e = Convert.ToInt32(Console.ReadLine());
            int[] array = { a, b, c, d, e };

            Console.WriteLine("Podane liczby to:");
            Console.WriteLine(string.Join(", ", array));

            max = a;
            if (max < b) max = b;
            if (max < c) max = c;
            if (max < d) max = d;
            if (max < e) max = e;
            Console.WriteLine($"{max} jest największe");
            min = a;
            if (min > b) min = b;
            if (min > c) min = c;
            if (min > d) min = d;
            if (min > e) min = e;
            Console.WriteLine($"{min} jest najmniejsze");
              

           
            Console.ReadLine();
        }
    }
}
