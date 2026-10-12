using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length: ");

            double length = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Enter width: ");

            double width = Convert.ToDouble(Console.ReadLine());

            double area = Convert.ToDouble(length * width);
            double areaV2 = Math.Round(area, 2);

            if (length == width)
                Console.WriteLine("This is a square of area: " + areaV2);

            else Console.WriteLine("This is a rectangle of area: " + areaV2);

            Console.ReadKey();
        }
    }
}
