using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rainfall = Convert.ToDouble(0);
            double total = Convert.ToDouble(0);




            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine("Enter the rainfall for month " + i + ": ");
                rainfall = Convert.ToDouble(Console.ReadLine());
                total = total + rainfall;
            }
            
            Console.WriteLine("Total rainfall: " + total);
            
            double avg = total / 12;
            double roundedAvg = Math.Round(avg , 2);
            Console.WriteLine("Average rainfall: "  + roundedAvg);

            Console.ReadKey();

        }
    }
}
