using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name: ");
             string firstName = Console.ReadLine();


            Console.WriteLine("Enter your surname: ");
            string surname = Console.ReadLine();

            string initial = firstName.Substring(0, 1);

            string fullname = initial + surname;

            string upperFull = fullname.ToUpper();


            Console.WriteLine(upperFull);







             








        }
    }
}
