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
             * Shift Left Bitwise Operation
             * 
             * Example:
             * 
             * 00001111  =  15
             *  SHIFT LEFT
             * 00011110  =  30
             */

            uint value = 15;              // 00001111

            uint doubled = value << 1;    // Result = 00011110 = 30
            uint shiftFour = value << 4;  // Result = 11110000 = 240
            
            Console.WriteLine(doubled);
            Console.WriteLine(shiftFour);

            /**
             * Shift Right Bitwise Operation
             */

            uint valueTwo = 240;                    // 11110000

            uint halved = valueTwo >> 1;            // Result = 01111000 = 120
            uint shiftFourValueTwo = value >> 4;    // Result = 00001111 = 15

            Console.WriteLine(halved);
            Console.WriteLine(shiftFourValueTwo);

            /**
             * Overflow bits
             */

            uint valueThree = 15;                   // 00001111
            uint halvedThree = valueThree >> 1;     // Result = 00000111 = 7

            Console.WriteLine(valueThree);
            Console.WriteLine(halvedThree);

            /**
             * Signed Integers
             */

            int valueFour = -240;
            int halvedFour = valueFour >> 1;      // Result = -120

            Console.WriteLine(valueFour);
            Console.WriteLine(halvedFour);

            /**
             * Compound Assignment Operators
             */

            int valueFive = 240;

            valueFive >>= 2;      // Result = 60
            Console.WriteLine(valueFive);
            valueFive <<= 1;      // Result = 120
            Console.WriteLine(valueFive);

        }
    }
}
