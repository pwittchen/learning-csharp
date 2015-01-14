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
            // Templates and placeholders

            string output;
            int selection = 5;

            // Generate the output string
            output = string.Format("You selected item {0} from the list.", selection);

            Console.WriteLine(output);     // Outputs "You selected item 5 from the list."

            int count = 10;

            // Generate the output string
            output = string.Format("You selected item {0} from {1}.", selection, count);

            Console.WriteLine(output);     // Outputs "You selected item 5 from 10."

            // Numeric formatting

            int value = 100;

            // Convert a number to hexadecimal
            output = string.Format("The decimal value {0} = {0:X} in hex.", value);

            Console.WriteLine(output);     // Outputs "The decimal value 100 = 64 in hex."

            // Including Braces in Templates

            // Convert a number to hexadecimal
            output = string.Format("{{The decimal value {0} = {0:X} in hex.}}", value);

            Console.WriteLine(output);     // Outputs "{The decimal value 100 = 64 in hex.}"

            // Console WriteLine Method

            // Convert a number to hexadecimal
            Console.WriteLine("{{The decimal value {0} = {0:X} in hex.}}", value);
        }
    }
}
