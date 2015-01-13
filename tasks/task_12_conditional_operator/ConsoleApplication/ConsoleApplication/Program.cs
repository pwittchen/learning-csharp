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
            int minimumValue = 5;
            int userEntered = Convert.ToInt32(Console.ReadLine());

            // Ensure that the user-provided value is at least the minimum permitted
            int valueToUse = userEntered >= minimumValue ? userEntered : minimumValue;
            Console.WriteLine(valueToUse);

            // Return the absolute value
            int value = -5;
            int absoluteValue = value >= 0 ? value : -value;
            Console.WriteLine(absoluteValue);
        }
    }
}
