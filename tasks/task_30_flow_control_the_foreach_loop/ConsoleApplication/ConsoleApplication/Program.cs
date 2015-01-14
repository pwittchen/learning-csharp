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
             * Cycling throught the collection
             */

            int[] values = new int[] { 1, 3, 5, 7, 9, 10, 8, 6, 4, 2 };
            int maxValue = int.MinValue;

            foreach (int i in values)
            {
                maxValue = i > maxValue ? i : maxValue;
            }

            Console.WriteLine("Largest = {0}", maxValue);   // Outputs "Largest = 10"

            /**
             * Breaking out of a loop
             */

            string[] items = new string[] { "A", "B", "C", "D", "E", "F", "G", "H" };
            int pos;

            foreach (string s in items)
            {
                if (s == "C")
                {
                    Console.WriteLine("C found");           // Outputs "C found"
                    break;
                }
            }

            /**
             * Completing a loop iteration early
             */
            
            foreach (int i in values)
            {
                if ((i % 2) == 0)
                {
                    continue;
                }

                Console.WriteLine(i);                       // Outputs the odd numbers only
            }
        }
    }
}
