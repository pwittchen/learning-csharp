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
            /*
                Operator precedence overview:
              
                Parentheses Operator
                ()
                Member Access Operator
                .
                Increment / Decrement Operators
                ++(postfix) --(postfix) ++(prefix) --(prefix)
                Complement Operators
                ! ~
                Basic Arithmetic Operators
                * / % + -
                Bitwise Shift Operators
                << >>
                Comparison Operators
                < > <= >=
                Equivalence Operators
                == !=
                Logic / Bitwise Operators
                & ^ | && ||
                Conditional Operator
                ?
                Assignment Operator
                =
                Compound Assignment Operators
                *= /= %= += -= >>= <<= &= ^= |=
                Null Coalescing Operator
                ??
             */

            int a = 3;
            int b = a++ + ++a;      // simple example of checking operators precedence
            Console.WriteLine(b);   // result: 8
        }
    }
}
