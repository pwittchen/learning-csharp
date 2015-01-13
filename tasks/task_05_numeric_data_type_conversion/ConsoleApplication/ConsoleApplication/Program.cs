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
             * Implicit Conversion
             */

            int iInteger = 1;
            long lLongInteger = 2;
            double dDoublePrecision = 3.456;

            // An int can be implicitly converted into a long
            lLongInteger = iInteger;

            // A double can receive an int
            dDoublePrecision = iInteger;

            // A long may be larger than the maximum int size so this is invalid
            // iInteger = lLongInteger;

            // A double may be truncated if assigned to a long so this is invalid
            // lLongInteger = dDoublePrecision;

            /**
             * Explicit Conversion
             */

            int iIntegerExplicit = 1;
            long lLongIntegerExplicit = 2;
            double dDoublePrecisionExplicit = 3.456;
            long lTooBigForIntExplicit = 9999999999;

            // Explicitly convert long to int
            iInteger = (int)lLongInteger;

            // Explicitly convert a double to an int.  The fractional part is truncated.
            iInteger = (int)dDoublePrecision;

            // Although accepted by the compiler, this generates an unpredictable
            // result because the value is too large to be assigned to an int
            iInteger = (int)lTooBigForIntExplicit;
        }
    }
}
