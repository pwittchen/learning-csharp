using System;
using System.Collections;
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
            // Creating BitArray
            BitArray flags = new BitArray(16);

            // Creating BitArray with default value
            BitArray flagsWithDefaultValue = new BitArray(16, true);

            // Creating BitArray with initial values
            bool[] bitsTwo = new bool[] { true, false, false, true };
            BitArray flagsTwo = new BitArray(bitsTwo);

            foreach (bool flag in flagsTwo)
            {
                Console.WriteLine(flag);
            }

            // Generating contents from array of bytes
            byte[] bytes = new byte[] { 1, 170 };
            BitArray flagsFromBytes = new BitArray(bytes);

            foreach (bool flag in flagsFromBytes)
            {
                Console.WriteLine(flag);
            }

            // Reading individual bits
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags.Get(1));

            // Writing individual bits
            flags[0] = true;
            flags.Set(1, true);

            // Writing multiple bits
            flags.SetAll(true);

            // BitArray Length
            Console.WriteLine(flags.Count);
            Console.WriteLine(flags.Length);
            flags.Length = 8;
            Console.WriteLine(flags.Length);            

            // Bitwise operations
            flags.Not();
            flags.And(new BitArray(16, true));
            flags.Or(new BitArray(16, true));
            flags.Xor(new BitArray(16, true));
        }
    }
}
