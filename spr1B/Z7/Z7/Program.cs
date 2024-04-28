using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę: ");
            int liczba = Convert.ToInt32(Console.ReadLine());
            if (liczba >= 3000) { liczba -= 3000; Console.Write("MMM"); } 
            else if (liczba >= 2000) { liczba -= 2000; Console.Write("MM"); }
            else if (liczba >= 1000) { liczba -= 1000; Console.Write("M"); }

            if (liczba >= 900) { liczba -= 900; Console.Write("CM"); }
            else if (liczba >= 800) { liczba -= 800; Console.Write("DCCC"); }
            else if (liczba >= 700) { liczba -= 700; Console.Write("DCC"); }
            else if (liczba >= 600) { liczba -= 600; Console.Write("DC"); }
            else if (liczba >= 500) { liczba -= 500; Console.Write("D"); }
            else if (liczba >= 400) { liczba -= 400; Console.Write("CD"); }
            else if (liczba >= 300) { liczba -= 300; Console.Write("CCC"); }
            else if (liczba >= 200) { liczba -= 200; Console.Write("CC"); }
            else if (liczba >= 100) { liczba -= 100; Console.Write("C"); }

            if (liczba >= 90) { liczba -= 90; Console.Write("XC"); }
            else if (liczba >= 80) { liczba -= 80; Console.Write("LXXX"); }
            else if (liczba >= 70) { liczba -= 70; Console.Write("LXX"); }
            else if (liczba >= 60) { liczba -= 60; Console.Write("LX"); }
            else if (liczba >= 50) { liczba -= 50; Console.Write("L"); }
            else if (liczba >= 40) { liczba -= 40; Console.Write("XL"); }
            else if (liczba >= 30) { liczba -= 30; Console.Write("XXX"); }
            else if (liczba >= 20) { liczba -= 20; Console.Write("XX"); }
            else if (liczba >= 10) { liczba -= 10; Console.Write("X"); }

            if (liczba == 9) { liczba -= 9; Console.Write("IX"); }
            else if (liczba == 8) { liczba -= 8; Console.Write("VIII"); }
            else if (liczba == 7) { liczba -= 7; Console.Write("VII"); }
            else if (liczba == 6) { liczba -= 6; Console.Write("VI"); }
            else if (liczba == 5) { liczba -= 5; Console.Write("V"); }
            else if (liczba == 4) { liczba -= 4; Console.Write("IV"); }
            else if (liczba == 3) { liczba -= 3; Console.Write("III"); }
            else if (liczba == 2) { liczba -= 2; Console.Write("II"); }
            else if (liczba == 1) { liczba -= 1; Console.Write("I"); }
            else if (liczba <= 0) { Console.Write(""); }

            Console.ReadLine();

        }
    }
}
