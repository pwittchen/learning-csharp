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

            // nullable numeric data types

            int? nullableInt;
            int? nullValue = null;
            int? notNull = 123;

            bool? answer1 = true;
            bool? answer2 = false;
            bool? answer3 = null;

             // int? copy = nullableInt;    // Invalid as nullableInt is not yet assigned
             // it become valid if we assign any value (numeric or null) to nullableInt

             // data type conversion

            int standardInteger = 123;
            int? nullableInteger;
            decimal standardDecimal = 12.34M;

            // Implicit conversion from int to int?
            nullableInteger = standardInteger;

            // Explicit conversion from int? to int
            standardInteger = (int)nullableInteger;

            // Explicit cast from decimal to int?
            nullableInteger = (int?)standardDecimal;

            // arithmetic operators

            int? a = 55;
            int? n = null;
            int? resultInt;

            resultInt = a * 2;         // result = 110
            resultInt = a * n;         // result = null

            // boolean operators

            bool? resultBool;

            resultBool = true & null;       // result = null
            resultBool = false & null;      // result = false

            resultBool = true | null;       // result = true
            resultBool = false | null;      // result = null

            resultBool = true ^ null;       // result = null
            resultBool = false ^ null;      // result = null

            // relational operators

            resultBool = a == n;        // result = false
            resultBool = a != n;        // result = true
            resultBool = n == null;     // result = true

            resultBool = a > n;         // result = false
            resultBool = a < n;         // result = false
            
        }
    }
}
