using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your full name, please separate first and surname with a space: ");
            string response = Console.ReadLine();

            int startPosition = 0;

            int spaceIndex = response.IndexOf(" ");

            string forename = (response.Substring(0, spaceIndex));
            string surname = (response.Substring(spaceIndex + 1));
            Console.WriteLine(forename + "\n" + surname);











        }
    }
}
