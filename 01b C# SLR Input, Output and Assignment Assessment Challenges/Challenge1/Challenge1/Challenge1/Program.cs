using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //this asks the user to input the length and allows them to do so
                Console.WriteLine("Enter length: ");
                int length = Convert.ToInt32(Console.ReadLine());

                //this asks the user to input the length and allows them to do so
                Console.WriteLine("Enter depth: ");
                int depth = Convert.ToInt32(Console.ReadLine());

                //this asks the user to input the length and allows them to do so
                Console.WriteLine("Enter height: ");
                int height = Convert.ToInt32(Console.ReadLine());

                //this calculates the volume
                int volume1 = length * depth * height;

                //this ensures the volume is in litres
                int volume2 = volume1 / 1000;

                //this outputs the volume in litres
                Console.WriteLine("The volume in Litres is: " + volume2 + " litres");






            }
        }
    }

}
    }
}
