using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR4_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {//Task 1: Understanding Check - Debugging Tools

            Console.Write("Enter the number of faces on the dice: ");
            int faces = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int result = random.Next(1, faces + 1);
            Console.WriteLine($"You rolled a {result}");




        }
    }
}
