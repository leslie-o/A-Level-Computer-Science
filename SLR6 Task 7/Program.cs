using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR6_Task_u7
{
    internal class Program
    {
        static void Main(string[] args)
        {//Task 7: TRY  Combining an Array with Selection – (Exam Question)

            //set up of initial temperatures array
            int[] temperatures = new int[365];
            Random rnd = new Random();
            int temp;
            for (int i = 0; i < 365; i++)
            {
                temp = rnd.Next(-5, 50);
                temperatures[i] = temp;
            }

            //initialise totals
            int bandA = 0;
            int bandB = 0;
            int bandC = 0;
            int bandD = 0;

            //Loop through the temperatures array
            for (int x = 0; x < temperatures.Length; x++)
            {
                //Check each temperature and update the relevant total
                /*Type code here */
            }

            //Output the total number of days for each band.
            /*Type code here */
        }
    }
}
