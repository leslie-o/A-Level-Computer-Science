using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter total value of goods purchased: ");
            double totalVal = Convert.ToDouble(Console.ReadLine());

            double discount = Convert.ToDouble(0);
            double amountOwed = totalVal - discount;

            if (amountOwed >= 200)
                discount = 0.1;      //10% off

            else if (amountOwed > 100 && amountOwed < 199.99)
                discount = 0.05; //5% off

            double priceReduction = totalVal * discount;
            double finalCost = Math.Round(totalVal - priceReduction, 2);

            Console.WriteLine("The value of goods is: £" + totalVal + 
                "\nThe discount given is: " + (discount*100) + "%" + 
                "\nThe final cost is: £" + finalCost);

            Console.ReadKey();

        }
    }
}
