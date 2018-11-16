using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace H_5DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double L = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());

            double hallArea = (L * 100) * (W * 100);
            double wardrobeArea = (A * 100) * (A * 100);
            double bench = hallArea / 10;
            double freeArea = hallArea - wardrobeArea - bench;
            double dancers = freeArea / 7040;
            Console.WriteLine(Math.Floor(dancers));
        }
    }
}
