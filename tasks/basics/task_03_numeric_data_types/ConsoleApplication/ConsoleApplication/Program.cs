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
            // variable declaration and assignment
            int a;
            a = 1;
            int b = 2;
            int c, d, e;
            c = d = e = 3;
            int g, h, i = 4;

            // integer data types
            bool j;         // boolean: true or false, 1 bit
            byte k;         // unsigned byte: from 0 to 255, 8 bits
            sbyte l;        // signed byte: from -128 to 127, 8 bits
            short m;        // signed short integer: from -32768 to 32767, 16 bits
            ushort n;       // unsigned short integer: from 0 to 65535, 16 bits
            int o;          // signed integer: from -2147483648 to 2147483647, 32 bits
            uint p;         // unsigned integer: from 0 to 4294967295, 32 bits
            long q;         // signed long integer: from -9*10^18 to 9*10^18, 64 bits
            ulong r;        // unsigned long integer: from 0 to 1.8*10^19, 64 bits

            //non-integer data types
            float s;        // single precision number from: +/-1.5*10^(-45) to +/-3.4*10^38, precision: 7 digits, 32 bits
            double t;       // single precision number from: +/-5*10^(-324) to +/-1.7*10^308, precision: 15 or 16 digits, 64 bits
            decimal u;      // single precision number from: +/-10^(-28) to +/-7.9*10^28, precision: 28 or 29 digits, 128 bits
        }
    }
}
