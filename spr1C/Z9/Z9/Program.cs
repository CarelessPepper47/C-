using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 1 ; i <= 10 ; i++)
            {
                for (j = 1; j <= 10; j++)
                { 
                    Console.Write($"{i * j,3}");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
