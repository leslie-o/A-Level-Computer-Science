using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR2_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {//Task 1: INVESTIGATE The String Data Type

            string sentence = "Programming is fun.";

            //Access the first character of the string (using the index)
            char firstChar = sentence[0];
            Console.WriteLine("The first character is: " + firstChar);

            // 1. Access the last character of the string (fill in the index)
            char lastChar = sentence[18];
            Console.WriteLine("The last character is: " + lastChar);

            // 2. Access the fifth character of the string (fill in the index)
            char fifthChar = sentence[4];
            Console.WriteLine("The fifth character is: " + fifthChar);

        }
    }
}


