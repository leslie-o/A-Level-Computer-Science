using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word to convert to ASCII Art: ");
            string Data = Console.ReadLine();
            Data = Data.ToUpper();

            // Header
            // Output +- for each character
            for (int Counter = 0; Counter < Data.Length; Counter++)
            {
                Console.Write("+-");
            }
            // Needs a final + appended
            Console.WriteLine("+");

            // Put a line between each character
            for (int Character = 0; Character < Data.Length; Character++)
            {
                Console.Write("|");
                Console.Write(Data[Character]);
            }
            // Needs a final line at the end of the string
            Console.WriteLine("|");

            // Footer
            // Output +- for each character
            for (int Counter = 0; Counter < Data.Length; Counter++)
            {
                Console.Write("+-");
            }
            // Needs a final + appended
            Console.WriteLine("+");

            Console.ReadLine();
        }
    }


}

