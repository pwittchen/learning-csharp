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
            // Concatenation Operator

            string start = "This is a ";
            string end = "concatenated string!";

            var concatOne = start + end;
            var concatTwo = start += end;

            Console.WriteLine(concatOne);
            Console.WriteLine(concatTwo);

            // Relational Operators

            string s1 = "String to compare.";
            string s2 = "String to compare.";
            string s3 = "String to Compare.";   // Note the capital "C"
            bool result;

            result = s1 == s2;                  // result = true
            result = s1 == s3;                  // result = false
            result = s1 != s2;                  // result = false
            result = s1 != s3;                  // result = true

            // Null Coalescing Operator

            string notNullString = "A string";
            string nullString = null;
            string nullTestString;

            nullTestString = notNullString ?? "Null";   // nullTestString = "A string"
            Console.WriteLine(nullTestString);
            nullTestString = nullString ?? "Null";      // nullTestString = "Null"            
            Console.WriteLine(nullTestString);
        }
    }
}
