using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLR2_Task_14
{
    internal class Program
    {
        static void Main(string[] args)
        {//Task 14 : TRY String Manipulation – Sentence Modifier 
            string sentence = "  Learning C# is fun and powerful!  ";

            // 1. Trim the leading and trailing spaces from the sentence (fill in the method)
            string trimmedSentence = /* Your Code Here */;

            // 2. Replace "fun" with "challenging" (fill in the method)
            string replacedSentence = /* Your Code Here */;

            // 3. Find the position of the word "C#" in the sentence (fill in the method)
            int position = /* Your Code Here */;

            Console.WriteLine("Trimmed Sentence: " + trimmedSentence);
            Console.WriteLine("Replaced Sentence: " + replacedSentence);
            Console.WriteLine("Position of 'C#': " + position);
        }
    }
}
