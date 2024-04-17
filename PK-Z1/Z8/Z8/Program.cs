using System;

namespace Z8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, wyraz;
            Console.Write("Ciąg artymetyczny: a(n) = 3n - 1 \nPodaj wyraz ciągu: ");
            n = Convert.ToInt32(Console.ReadLine());

            wyraz = 3 * n - 1;

            Console.WriteLine($"Wartość wyrazu {n} to: {wyraz}");
            Console.ReadLine();
        }
    }
}
