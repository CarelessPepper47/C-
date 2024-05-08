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
            Console.WriteLine("Podaj liczbę n:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbę k:");
            int k = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= k; j++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();

        }
    }
}
