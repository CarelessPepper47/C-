using System;

namespace Z5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Podaj rok:");
            int rok = Convert.ToInt32(Console.ReadLine());
            if (rok % 4 == 0 && rok % 100 != 0) 
            {
                Console.WriteLine($"Rok {rok} jest przestępny");
            } 
            else
            {
                Console.WriteLine($"Rok {rok} nie jest przestępny");
            }
            Console.ReadLine();
        }
    }
}
