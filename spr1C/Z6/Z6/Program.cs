using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Podaj liczbę naturalną n:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n-i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2*i-1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");

            }
            Console.ReadLine();
        }
    }
}
