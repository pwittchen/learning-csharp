using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conversion Syntax

            // Convert a string to an integer
            int stringToInt = Convert.ToInt32("25");
            Console.WriteLine(stringToInt);

            // Booleans can be converted too
            bool stringToBoolean = Convert.ToBoolean("true");
            Console.WriteLine(stringToBoolean);

            // Numeric Conversions with Convert
            decimal originalValue = 25.5M;
            int converted = Convert.ToInt32(originalValue);     // Result is 26
            int casted = (int)originalValue;                    // Result is 2
            Console.WriteLine(converted);
            Console.WriteLine(casted);

            // Parse method
            string toConvert = "100";
            int convertedInt = int.Parse(toConvert);            // Result is 100
            float convertedFloat = float.Parse(toConvert);      // Result is 100.0
            Console.WriteLine(convertedInt);
            Console.WriteLine(convertedFloat);
        }
    }
}
