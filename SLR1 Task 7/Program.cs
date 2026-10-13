using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR1_Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {//Task 7: TRY Combined Operators 
            int a = 20;
            int b = 5;

            //Complete the code by performing each of the following steps 
            //using the appropriate operators.
            a++;
            a *=3;
            a += b;
            a /= 2;
            b--;
            a -= b;

            // Output the final values of a and b
            Console.WriteLine("Final value of a: " + a);
            Console.WriteLine("Final value of b: " + b);
        }
    }
}
