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
            int current = 1;
            string output = String.Empty;

            // Loop while the value being checked is 1000 or less 
            while (current <= 1000)
            {
                output += current.ToString() + " ";
                current *= 3;
            }

            Console.WriteLine(output); // Outputs "1 3 9 27 81 243 729 "

            // do-while loop

            int value = 1;
            int factorial = 10;

            do
            {
                value *= factorial;
                factorial--;
            } while (factorial > 1);

            Console.WriteLine(value); // Outputs "3628800"
        }
    }
}
