using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the previous meter reading?: ");
            double previous = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("What is the current meter reading?: ");
            double current = Convert.ToDouble(Console.ReadLine());


            double calorificVal = Convert.ToDouble(39.3);
            Console.WriteLine("The calorific value is: " + calorificVal);

            double unitsUsed = current - previous;
            double kWh = unitsUsed * 1.022 * calorificVal / 3.6;

            double energyCost = (kWh * (2.84 / 100));
            Console.WriteLine("The cost is: " + Math.Round(energyCost,2) + "£");















        }
    }
}
