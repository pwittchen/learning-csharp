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
            int toTest = 5;

            // if statement

            if (toTest >= 0) Console.WriteLine("Positive");     // Outputs "Positive"
            if (toTest < 0) Console.WriteLine("Negative");      // Outputs nothing

            // if-else statement

            if (toTest >= 0)
                Console.WriteLine("Positive");      // Outputs "Positive"
            else
                Console.WriteLine("Negative");

            // nested if statements

            if (toTest >= 0)
            {
                if (toTest == 0)
                    Console.WriteLine("Zero");
                else
                    Console.WriteLine("Positive");  // Outputs "Positive"
            }
            else
            {
                Console.WriteLine("Negative");
            }
        }
    }
}
