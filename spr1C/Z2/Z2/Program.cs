using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, wynik = 1;
            Console.WriteLine("Podaj liczbę naturalną n:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++) {
                wynik *= 2;
            }
            Console.WriteLine($"2^{n}={wynik}");
            Console.ReadLine();

        }
    }
}
