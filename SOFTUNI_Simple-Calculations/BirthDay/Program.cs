using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BirthDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            int volume = length * width * height;
            double volumeInLiters = volume * 0.001;
            double finalPercent = percent * 0.01;
            double water = volumeInLiters * (1 - finalPercent);
            //Console.WriteLine(Math.Round(water, 3));
            Console.WriteLine($"{water:F3}");



        }
    }
}
