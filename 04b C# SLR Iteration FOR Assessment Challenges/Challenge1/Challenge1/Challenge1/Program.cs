using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Challenge1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int c = 0;
            {
                for (c = 10; c > 0; c--)
                {
                    Console.WriteLine(c);
                    Thread.Sleep(1000);
                }

                if (c == 0)
                    Console.WriteLine("Lift-off!");
            }


                Console.ReadLine();





      

        





        }
    }
}
