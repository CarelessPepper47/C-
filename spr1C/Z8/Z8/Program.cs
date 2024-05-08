using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rok początkowy:");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj rok końcowy:");
            int koniec = Convert.ToInt32(Console.ReadLine());

            for (int i = start;  i <= koniec; i++) 
            {
                if (((i%4 == 0) && (i%100 != 0)) || (i%400 == 0))
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
