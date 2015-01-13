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
            // Number to String conversion

            // ToString() method
            object anObject = new object();
            Console.WriteLine(anObject.ToString());            // Outputs "System.Object"

            // Basic Numeric Conversion Using ToString

            int quantity = 1500;
            float price = 1.50F;
            float discount = 0.05F;
            bool sold = true;            

            Console.WriteLine(quantity.ToString());            // Outputs "1500"
            Console.WriteLine(price.ToString());               // Outputs "1.5"
            Console.WriteLine(sold.ToString());                // Outputs "True"

            // formatting converted numbers

            Console.WriteLine(quantity.ToString("n0"));        // Outputs "1,500"
            Console.WriteLine(price.ToString("c"));            // Outputs "£1.50"
            Console.WriteLine(discount.ToString("p1"));        // Outputs "5.0 %"

            // Zero placeholder

            int small = 12;
            int large = 123456;
            float tiny = 1.234F;

            Console.WriteLine(small.ToString("0000"));         // Outputs "0012"
            Console.WriteLine(large.ToString("0000"));         // Outputs "123456"
            Console.WriteLine(tiny.ToString("0000"));          // Outputs "0001"

            // Decimal Point placeholder

            small = 12;
            double largeDouble = 123456.789;
            tiny = 1.234F;

            Console.WriteLine(small.ToString("00.00"));        // Outputs "12.00"
            Console.WriteLine(largeDouble.ToString("00.00"));        // Outputs "123456.79"
            Console.WriteLine(tiny.ToString("00.00"));         // Outputs "01.23"

            // Digit Placeholder
            
            Console.WriteLine(small.ToString("##.##"));        // Outputs "12"
            Console.WriteLine(large.ToString("##.##"));        // Outputs "123456.79"
            Console.WriteLine(tiny.ToString("##.##"));         // Outputs "1.23"
            Console.WriteLine(0.ToString("##.##"));            // Outputs an empty string

            // Thousands Separator Placeholder

            small = 12;
            largeDouble = 123456.789;
            tiny = 1.234F;

            Console.WriteLine(small.ToString("#,#.00"));       // Outputs "12.00"
            Console.WriteLine(largeDouble.ToString("#,#.##")); // Outputs "123,456.79"
            Console.WriteLine(tiny.ToString("#,#.##"));        // Outputs "1.23"

            // Number Scaling Placeholder

            int miles = 123456789;

            Console.WriteLine(miles.ToString("#,#,"));         // Outputs "123,457"
            Console.WriteLine(miles.ToString("#,#,,.###"));    // Outputs "123.457"
            Console.WriteLine(miles.ToString("#,#,,"));        // Outputs "123"

            // Percentage Placeholder

            small = 12;
            largeDouble = 123456.789;
            tiny = 0.0015F;

            Console.WriteLine(small.ToString("#,#.#%"));       // Outputs "1,200%"
            Console.WriteLine(largeDouble.ToString("#,#.#%")); // Outputs "12,345,678.9%"
            Console.WriteLine(tiny.ToString("#,#.#%"));        // Outputs ".2%"

            small = 12;
            largeDouble = 123456.789;
            tiny = 0.0015F;

            // Custom Exponential Notation

            Console.WriteLine(small.ToString("0.0E0"));         // Outputs "1.2E1"
            Console.WriteLine(largeDouble.ToString("0.00e00")); // Outputs "1.23e05"
            Console.WriteLine(tiny.ToString("0.00E00"));        // Outputs "1.50E-03"

            small = 12;
            largeDouble = 123456.789;
            tiny = 0.0015F;

            Console.WriteLine(small.ToString("0.0E-0"));       // Outputs "1.2E1"
            Console.WriteLine(large.ToString("0.00e+00"));     // Outputs "1.23e+05"
            Console.WriteLine(tiny.ToString("0.00E+00"));      // Outputs "1.50E-03"

            // Literal characters

            Console.WriteLine(12345.ToString("00-00-00"));     // Outputs "01-23-45"
            Console.WriteLine(12345.ToString("0'E'"));         // Outputs "12345E"

            // Escape characters

            Console.WriteLine(123.45.ToString("\\'0.00\\'"));  // Outputs "'123.45'"
            Console.WriteLine(12345.ToString("000\\\\000"));   // Outputs "012\345"

            // Section Separator character

            Console.WriteLine(1.ToString("0.0;(0.0)"));         // Outputs "1.0"
            Console.WriteLine((-1).ToString("0.0;(0.0)"));      // Outputs "(1.0)"

            Console.WriteLine(1.ToString("0.0;(0.0);#.#"));     // Outputs "1.0"
            Console.WriteLine((-1).ToString("0.0;(0.0);#.#"));  // Outputs "(1.0)"
            Console.WriteLine(0.ToString("0.0;(0.0);#.#"));     // Outputs an empty string

            Console.WriteLine(1.ToString("0.0;;#.#"));          // Outputs "1.0"
            Console.WriteLine((-1).ToString("0.0;;#.#"));       // Outputs "-1.0"
            Console.WriteLine(0.ToString("0.0;;#.#"));          // Outputs an empty string
        }
    }
}
