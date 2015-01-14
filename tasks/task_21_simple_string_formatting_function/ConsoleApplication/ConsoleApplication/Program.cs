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
            // Simple string formatting functions

            /**
             * Trimming
             */            

            string inputted = "  SampleString  ";

            Console.WriteLine(inputted);
            Console.WriteLine(inputted.TrimStart());        // Outputs "SampleString"
            Console.WriteLine(inputted.TrimEnd());          // Outputs "SampleString"
            Console.WriteLine(inputted.Trim());             // Outputs "SampleString"

            string original = "  SampleString  ";
            string trimmed = original.Trim();

            Console.WriteLine(original);                    // Outputs "  SampleString  "
            Console.WriteLine(trimmed);                     // Outputs "SampleString"

            /**
             * Padding
             */

            string value1 = "£1.00";
            string value2 = "£10.00";
            string value3 = "£100.00";

            // Output a right-aligned column
            Console.WriteLine(value1.PadLeft(8));           // Outputs "   £1.00"
            Console.WriteLine(value2.PadLeft(8));           // Outputs "  £10.00"
            Console.WriteLine(value3.PadLeft(8));           // Outputs " £100.00"

            // Output a left-aligned column
            Console.WriteLine(value1.PadRight(8));          // Outputs "£1.00   "
            Console.WriteLine(value2.PadRight(8));          // Outputs "£10.00  "
            Console.WriteLine(value3.PadRight(8));          // Outputs "£100.00 "

            // Trying to pad a string that is too long
            Console.WriteLine(value1.PadRight(3));          // Outputs "£1.00"

            /** 
             * Text Case 
             */

            string value4 = "SampleString";
            Console.WriteLine(value4.ToLower());
            Console.WriteLine(value4.ToUpper());
        }
    }
}
