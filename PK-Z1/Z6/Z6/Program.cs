using System;

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
            /* try {
             Console.WriteLine(a / b);
             }
             catch (DivideByZeroException) {
             Console.WriteLine("Nie dziel przez 0!");
            } */
            iloraz = a / b;
            Console.WriteLine("Suma: {0}\nRoznica: {1}\nIloczyn: {2}\nIloraz: {3}", suma, roznica, iloczyn, iloraz);
            Console.ReadLine();
        }
    }
}
