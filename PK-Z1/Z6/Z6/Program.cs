using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, suma, roznica, iloczyn, iloraz;
            Console.Write("Podaj liczbę a:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbę b:");
            b = Convert.ToDouble(Console.ReadLine());
            suma = a + b;
            roznica = a - b;
            iloczyn = a * b;
            try {
                iloraz = a / b;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Suma: {0}\nRoznica: {1}\nIloczyn: {2}\nIloraz: {3}", suma, roznica, iloczyn, iloraz)
        }
    }
}
