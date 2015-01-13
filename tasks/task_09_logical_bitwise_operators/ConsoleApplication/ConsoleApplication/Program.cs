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
             *   Bitwise AND operations
             * 
             *   Examples of bitwise AND operations on binary numbers:
             * 
             *   10111011  =  187
             *   00100000  =  32
             *    AND
             *   00100000  =  32
             * 
             *   10111011  =  187
             *   11011111  =  223
             *    AND
             *   10011011  =  155
             */

            int deviceConfiguration = 187;   // 10111011
            int carrierMask = 32;            // 00100000
            int connectedMask = 64;          // 01000000

            // Check the carrier
            int carrier = deviceConfiguration & carrierMask;        // Result = 32

            // Check the connection status
            int connected = deviceConfiguration & connectedMask;    // Result = 0

            Console.WriteLine(carrier);
            Console.WriteLine(connected);

            /**
             *   Bitwise OR operations
             *   
             *   Examplese of bitwise OR operations on binary numbers:
             * 
             *   10111011  =  187
             *   00000100  =  4
             *     OR
             *   10111111  =  191
             */

            int deviceConfigurationTwo = 187;   // 10111011
            int echoMask = 4;                   // 00000100

            // Set the carrier
            int newConfiguration = deviceConfigurationTwo | echoMask;   // Result = 191

            Console.WriteLine(newConfiguration);
        }
    }
}
