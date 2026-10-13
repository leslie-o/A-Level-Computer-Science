using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR2_Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {//Task 10 : INVESTIGATE Inserting, Removing, and Replacing a Substring
            string sentence = "Hello, World!";

            // Insert "Beautiful " after "Hello, " (using the .Insert(,) method)
            string insertedSentence = /* Your Code Here */;

            // Remove "World" from the sentence (using the .Remove(,) method)
            string removedSentence = /* Your Code Here */;

            // Replace "World" with "Universe" (using the .Replace(,) method)
            string replacedSentence = /* Your Code Here */;

            Console.WriteLine("Inserted Sentence: " + insertedSentence);
            Console.WriteLine("Removed Sentence: " + removedSentence);
            Console.WriteLine("Replaced Sentence: " + replacedSentence);
        }
    }
}
