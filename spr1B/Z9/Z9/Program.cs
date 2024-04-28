using System;
using System.Diagnostics.Eventing.Reader;

namespace Z9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, m01, m02;
            Console.WriteLine("Dana jest funkcja kwadratowa f(x)=ax^2+bx+c");
            Console.WriteLine("Podaj współczynnik a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj współczynnik b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj współczynnik c: ");
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Twoja funkcja to {a}x^2+{b}x+{c}");

            delta = b * b - 4 * a * c;

            m01 = (-b + Math.Sqrt(delta)) / 2 * a;
            m02 = (-b - Math.Sqrt(delta)) / 2 * a;

            if (delta == 0) { double m00 = -b / 2 * a;  Console.WriteLine($"Jest jedno miejsce zerowe: {m00}"); }
            else if (delta > 0) { Console.WriteLine($"Miejsca zerowe to: \nx1 = {m01}\nx2 = {m02}"); }
            else { Console.WriteLine("Brak miejsc zerowych");  }

            Console.ReadLine();

        }
    }
}
