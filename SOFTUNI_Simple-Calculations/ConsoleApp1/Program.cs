using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int third = number % 10;
            int second = ((number - third) / 10) % 10;
            int first = ((number - third) - (second * 10)) / 100;

            //Console.WriteLine(first);
            //Console.WriteLine(second);
            //Console.WriteLine(third);

            for (int i = 1; i <= third; i++)
            {
                for (int j = 1; j <= second; j++)
                {
                    for (int k = 1; k <= first; k++)
                    {
                        Console.WriteLine($"{i} * {j} * {k} = {i * j * k};");
                    }
                }
            }


        }
    }
}
