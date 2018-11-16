using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int men = int.Parse(Console.ReadLine());
            int women = int.Parse(Console.ReadLine());
            int maxTables = int.Parse(Console.ReadLine());

            int m = 1;

            int occupiedTables = 0;

            string output = "";

            while (m <= men)
            {
                int w = 1;

                while (w <= women)
                {
                    occupiedTables++;
                    if (occupiedTables > maxTables)
                    {
                        break;
                    }
                    output += $"({m} <-> {w}) ";
                    w++;
                }
                m++;
            }


            //for (int m = 1; m <= men; m++)
            //{
            //    for (int w = 1; w <= women; w++)
            //    {
            //        occupiedTables++;
            //        if (occupiedTables > maxTables)
            //        {
            //            break;
            //        }
            //        output += $"({m} <-> {w}) ";
            //    }
            //}
            Console.WriteLine(output);
        }
    }
}
