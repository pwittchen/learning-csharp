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
            bool a = true;
            bool b = false;
            bool c = false;
            bool result;

            // equivalence operator

            result = a == b;        // false
            result = b == c;        // true
            result = b == false;    // true            

            a = true;
            b = false;
            c = false;
            bool resultTwo;

            // inequality operator

            resultTwo = a != b;        // true
            resultTwo = b != c;        // false
            resultTwo = b != true;     // true            

            a = true;
            b = false;
            bool resultThree;

            // not operator

            resultThree = !a;            // false
            resultThree = !b;            // true
            resultThree = !true;         // false

            // and operator

            a = true;
            b = false;
            c = true;
            bool resultFour;

            resultFour = a & b;         // false
            resultFour = a & c;         // true
            resultFour = a & (a == c);  // true

            // or operator

            a = true;
            b = false;
            c = false;
            bool resultFive;

            resultFive = a | b;         // true
            resultFive = b | c;         // false
            resultFive = a | b | c;     // true
        }
    }
}
