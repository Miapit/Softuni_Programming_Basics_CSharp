using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA6
{
    class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int numberOfColumnsInFirstSector = int.Parse(Console.ReadLine());
            int numberPlacesNecheten = int.Parse(Console.ReadLine());
            int numberOfColumns = 0;
            int br = 0;

            for (char sector  = 'A'; sector <= lastSector; sector  ++)
            {
                for (int i = 1; i <= numberOfColumnsInFirstSector; i++)
                {
                    if (i % 2 == 0)
                    {
                        numberOfColumns = numberPlacesNecheten + 2;
                    }
                    else {
                        numberOfColumns = numberPlacesNecheten;
                    }

                    for (int p = 1; p <= numberOfColumns; p++)
                    {
                        string alphabet = "abcdefghigklmnopqrstuvwxyz";
                        Console.WriteLine($"{sector}{i}{alphabet[p-1]}");
                        br++;
                    }
                }
                numberOfColumnsInFirstSector++;
                
            }
            Console.WriteLine(br);
        }
    }
}
