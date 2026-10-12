using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Extension2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many hours you need: ");
            int hoursNeeded = Convert.ToInt32(Console.ReadLine());
            
            DateTime current = DateTime.Now;
            Console.WriteLine("Current time is: " + current);

            DateTime expirationTime = current.AddHours(hoursNeeded);

            double cost = 0;

            if (hoursNeeded <= 2)
                cost = 3.50;
            else if (hoursNeeded > 2 && hoursNeeded <= 4)
                cost = 5.00;
            else if (hoursNeeded > 4 && hoursNeeded <= 12)
                cost = 10.00;

            Console.WriteLine(current);
            Console.WriteLine(expirationTime);
            Console.WriteLine("The price for parking for " + hoursNeeded+ " hours is: £" +cost);


            Console.ReadKey();



        }
    }
}
