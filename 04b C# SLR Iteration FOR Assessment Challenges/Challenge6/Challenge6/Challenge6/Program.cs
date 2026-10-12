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
            Console.WriteLine("Enter start value: ");
            int start = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter end value: ");
            int end = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter divisble number you'd like to check: ");
            int div = Convert.ToInt32(Console.ReadLine());

            int count = 0;

            for (int i = start; i <= end; i++)
            {
                if (i % div == 0)
                { 
                    Console.WriteLine(i + " is divisible by  " + div);
                    count++;
                }
            } 


            Console.WriteLine(count + " numbers between " + start + " and " + end + " are divisible by " + div);


            Console.ReadKey();











        }
    }
}
