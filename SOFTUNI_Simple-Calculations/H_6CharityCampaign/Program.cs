using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace H_6CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int goffrets = int.Parse(Console.ReadLine());
            int pancaces = int.Parse(Console.ReadLine());

            double cakesCost = cakes * 45;
            double goffretsCost = goffrets * 5.8;
            double pancacesCost = pancaces * 3.2;

            double sumday = (cakesCost + goffretsCost + pancacesCost) * workers;
            double sumCampaign = sumday * days;
            double totalsum = sumCampaign - (0.125*sumCampaign);

            Console.WriteLine($"{totalsum:F2}");
        }
    }
}
