using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SLR6_Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {//Task 6: TRY  Creating and Iterating through an  Array – (Exam Question)

            //Complete the array declaration to create an empty array with 10 spaces.
            string[] names = new string [11];

            //Read in 10 names and store in the array names
            for (int i = 1; i < names.Length; i++)
            {
                Console.Write("Enter a name: ");
                names[i] = Console.ReadLine();
            }

            //Output each name using the formatting shown.  
            for (int x = 1; x < names.Length; x++)
            {
                Console.WriteLine("Number: " + x + " Name: "+ names[x]);
            }


            Console.ReadKey();
        }
    }
}
