using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the period table (work in progress, so only 6 elements currently)" +
                "\nLithium (Li)," +
                "\nSodium (Na)," +
                "\nPotassium (K)," +
                "\nOxygen (O)," +
                "\nSulfur (S)," +
                "\nSelenium (Se)");


            Console.WriteLine("Enter element's name or symbol: ");
            string choice = Console.ReadLine();



            string[] elements = { "Lithium", "Sodium", "Potassium", "Oxygen", "Sulfur", "Selenium" };
            string[] symbols = { "Li", "Na", "K", "O", "S", "Se" };
            double[] weights = { 6.94, 22.990, 39.098, 15.999, 32.06, 78.971 };
            string[] groups = { "Alkali metals", "Alkali metals", "Alkali metals", "Chalcogens", "Chalcogens", "Chalcogens", };

            int index = -1;

            switch (choice)
            {
                case "Lithium":
                case "Li":
                    index = 0;
                    break;


                case "Sodium":
                case "Na":
                    index = 1;
                    break;

                case "Potassium":
                case "K":
                    index = 2;
                    break;

                case "Oxygen":
                case "O":
                    index = 3;
                    break;

                case "Sulfur":
                case "S":
                    index = 4;
                    break;


                case "Selenium":
                case "Se":
                    index = 5;
                    break;

            }



            if (index != -1)
                Console.WriteLine("Element: " + elements[index] + " (" + symbols[index] + ")");
                Console.WriteLine("Atomic weight: " + weights[index]);
                Console.WriteLine("Group: " + groups[index]);


            Console.ReadKey();

        }
    }
}
