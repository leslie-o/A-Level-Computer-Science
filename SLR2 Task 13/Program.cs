using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR2_Task_13
{
    internal class Program
    {
        static void Main(string[] args)
        {//Task 13 : TRY String Manipulation – URL Formatter
            string url = "   WWW.example.COM/home   ";

            // 1. Trim the white spaces from the URL (fill in the method)
            string trimmedUrl = /* Your Code Here */;

            // 2. Convert the URL to lowercase (fill in the method)
            string lowerCaseUrl = /* Your Code Here */;

            // 3. Extract the domain name "example.com" from the URL (fill in the method)
            string domain = /* Your Code Here */;

            Console.WriteLine("Cleaned URL: " + lowerCaseUrl);
            Console.WriteLine("Domain Name: " + domain);
        }
    }
}
