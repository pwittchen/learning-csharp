using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * String Concatenation
             */

            string start = "This is a ";
            string end = "concatenated string";
            string concat = start + end;
            Console.WriteLine(concat);

            /**
             * Inserting string into strings
             */

            string template = "Please ask for  on arrival.";
            string tutor = "Lisa";
            Console.WriteLine(template.Insert(15, tutor));

            /**
             * Removing characters from string
             */

            string sample = "The quick brown fox jumps over the lazy dog.";

            string resultOne = sample.Remove(16);
            resultOne = sample.Remove(16, 24);
            Console.WriteLine(resultOne);

            /**
             * Extracting text from a string
             */

            string resultTwo = sample.Substring(16);
            resultTwo = sample.Substring(16, 24);
            Console.WriteLine(resultTwo);

            /**
             * Search and replace
             */

            sample = "The brown fox";
            string resultThree = sample.Replace("brown", "red");
            Console.WriteLine(resultThree);

            /**
             * Copying strings
             */

            Console.WriteLine(sample);
            string resultFour = string.Copy(sample);
            Console.WriteLine(resultFour);
        }
    }
}
