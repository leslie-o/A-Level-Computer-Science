using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first city's name: ");
            string firstcityName = Console.ReadLine();

            Console.WriteLine("Enter the second city's name: ");
            string secondcityName = Console.ReadLine();

            string first4city = firstcityName.Substring(0, 4).ToUpper();
            string second4city = secondcityName.Substring(0, 4).ToUpper();


            Console.WriteLine(first4city + " - " + second4city);











        }
    }
}
