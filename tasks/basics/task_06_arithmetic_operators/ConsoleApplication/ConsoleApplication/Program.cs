using System;

namespace ConsoleApplication
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Outputting Numeric Values

            var quantity = 5;
            Console.WriteLine(quantity); // Outputs 5

            // Basic Arithmetic Operators

            var a = 6;
            var b = 3;
            int result;

            result = a + b; // result = 9
            result = a - b; // result = 3
            result = a*b; // result = 18
            result = a/b; // result = 2
            result = a + b - 1; // result = 8

            var c = 7;
            var d = 3;
            int integerResultOne;
            float floatResultOne;

            integerResultOne = c/d; // integerResult = 2  (truncated)
            floatResultOne = c/d; // floatResult = 2.0  (truncated)
            floatResultOne = (float) c/d; // floatResult = 2.33333325

            var e = 10;
            var f = 3;
            var g = 3.5F;
            int integerResultTwo;
            float floatResultTwo;

            integerResultTwo = e%f; // integerResult = 1
            floatResultTwo = e%f; // floatResult = 1.0
            floatResultTwo = e%g; // floatResult = 3.0

            // Increment and Decrement Operators

            // All of these commands add one to the variable "h"
            var h = 1;
            h = h + 1;
            ++h; // prefix
            h++; // postfix

            // All of these commands subtract one from the variable "h"
            h = h - 1;
            --h;
            h--;

            // Operator Precedence

            int i = 10;
            int j = 6;
            int k = 2;
            int resultTwo;

            // * is applied before +
            resultTwo = i + j * k;             //result = 22

            // / is applied before -
            resultTwo = i - j / k;             //result = 7

            // Order of precedence is *, /, +, -
            resultTwo = i * j + j / k - 1;     //result = 62

            // Parentheses Operator
            int l = 10;
            int m = 6;
            int n = 2;
            int resultThree;

            resultThree = (l + m) * n;             //result = 32
            resultThree = (l - m) / n;             //result = 2
            resultThree = l * (m + m / (n - 1));   //result = 120
        }
    }
}