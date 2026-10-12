using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter nitrate level: ");
            double nitrateLevel= Convert.ToDouble(Console.ReadLine());

            double dosage = 0;

            if (nitrateLevel > 10)
                dosage = 3;

            else if (nitrateLevel > 2.5)
                dosage = 2;

            else if (nitrateLevel > 1)
                dosage = 1;

            else if (nitrateLevel <= 1)
                dosage = 0.5;


            Console.WriteLine("The dose is: " + dosage + "ml");


        }
    }
}
