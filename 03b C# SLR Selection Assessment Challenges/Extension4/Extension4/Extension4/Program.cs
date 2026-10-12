using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number from 1-7: ");
            int dayNumber = Convert.ToInt32(Console.ReadLine());

            string[] days = { "None", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday​" };

            Console.WriteLine("Enter format (either day, short or char): ");
            string format = Console.ReadLine();



            string dayName = days[dayNumber];

            if (format == "day")
                Console.WriteLine(dayName);

            if (format == "short")
                Console.WriteLine(dayName.Substring(0,3));

            if (format == "char")
                Console.WriteLine(dayName.Substring(0, 1));




            Console.ReadKey();


        }
    }
}
