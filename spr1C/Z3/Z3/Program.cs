using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, wynik = 0;
            Console.WriteLine("Podaj liczbę całkowitą n:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++) {
                wynik += i;
            }
            Console.WriteLine($"1+...+{n}={wynik}");
            Console.ReadLine();

        }
    }
}
