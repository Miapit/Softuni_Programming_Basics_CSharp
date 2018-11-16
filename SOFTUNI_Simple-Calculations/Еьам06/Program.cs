using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam06
{
    class Program
    {
        static void Main(string[] args)
        {
            int freeSpaceWidth = int.Parse(Console.ReadLine());
            int freeSpaceLength = int.Parse(Console.ReadLine());
            int freeSpaceHeight = int.Parse(Console.ReadLine());

            int freeVolume = freeSpaceWidth * freeSpaceLength * freeSpaceHeight;
            int sumBoxes = 0;
            while (true)
            {
                string numberBoxes = Console.ReadLine();
                
                if (numberBoxes == "Done") {
                    Console.WriteLine($"{freeVolume - sumBoxes} Cubic meters left.");
                    break;
                }
                sumBoxes = sumBoxes + int.Parse(numberBoxes);
                if (freeVolume < sumBoxes)
                {
                    Console.WriteLine($"No more free space! You need {sumBoxes - freeVolume} Cubic meters more.");
                    break;
                }
                

            }
        }
    }
}
