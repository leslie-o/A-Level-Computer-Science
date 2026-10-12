using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input water temperature: ");
            double temperature = Convert.ToDouble(Console.ReadLine());

            string state = "empty";

            if (temperature >= 100)
                state = "Gaseous";

            else if (temperature >= 1 && temperature <= 99)
                state = "Liquid";


            else
                state = "Solid";
            double newTemp = Convert.ToDouble(Math.Round(temperature, 2));

            Console.WriteLine("The state of the water is: " + state + "\nThe temperture is: " + newTemp);
        }
    }
}
