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
            Console.WriteLine("Enter diameter: ");
            double diameter = Convert.ToDouble(Console.ReadLine());
            double circumference = Convert.ToDouble(diameter * 3.14);
            Console.WriteLine("Circumference: " + circumference);
            double radius = Convert.ToDouble(diameter / 2);
            Console.WriteLine("Radius: " + radius);
            double area = Convert.ToDouble(Math.Pow(radius,2) * 3.14 );
            Console.WriteLine("Area: " + area);
            Console.WriteLine("Enter arc angle: ");
            double arcAngle = Convert.ToDouble(Console.ReadLine());
            double arcLength = Convert.ToDouble((circumference * arcAngle) / 360);
            Console.WriteLine("Arc length: " + arcLength);
            double RoundedarcLength = Math.Round(arcLength, 2);
            Console.WriteLine("Rounded Arc Length: " + RoundedarcLength);


            Console.ReadKey();

        }
    }
}
