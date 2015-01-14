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
            // the for loop
            int i;
            string numbers = "";

            for (i = 1; i <= 5; i++)
                numbers += i.ToString();

            Console.WriteLine(numbers); // Outputs: "12345"

            // the for loop using code block

            int[] squares = new int[11];

            for (i = 0; i <= 10; i++)
            {
                int squareValue = i * i;
                Console.Write(squareValue);
            }

            // the for loop using variable initialisation

            for (int j = 0; j <= 10; j++)
            {
                int squareValue = j * j;
                squares[j] = squareValue;
            }            

            // multiple loop control variables

            Console.WriteLine();

            for (int k = 0, l = 5; k <= l; k += 2, l++)
            {
                Console.WriteLine("k = {0}, l = {1}", k, l);
            }

            // excluding the loop control variable from the condition

            bool finished = false;

            for (int j = 0; !finished; j++)
            {
                int squareValue = j * j;
                squares[j] = squareValue;
                finished = (j == 10) || (squareValue > 50);
            }

            // using incomplete loop definitions

            for (; i <= 10; i++)
            {
                int squareValue = i * i;
                squares[i] = squareValue;
            }

            // this is going to loop infinitely and incrementing j value
//            for (int j = 0; ; j++)
//            {
//                Console.WriteLine("Looping, iteration #{0}", j);
//            }

            // this is an inifnite loop as well
//            for (;;)
//            {
//                Console.WriteLine("Looping...");
//            }

            int total = 0;
            for (int j = 1; j <= 10; total += j++) ;
            Console.WriteLine("Total = {0}", total);        // Outputs "Total = 55"

            // nested loops

            int[,] table = new int[13, 13];

            // Outer loop
            for (int row = 0; row <= 12; row++)
            {
                // Inner loop
                for (int col = 0; col <= 12; col++)
                {
                    table[row, col] = row * col;
                }
            }

            // breaking the loop

            string[] items = new string[] { "A", "B", "C", "D", "E", "F", "G", "H" };
            int pos;

            for (pos = 0; pos <= items.Length; pos++)
            {
                if (items[pos] == "C")
                {
                    break;
                }
            }

            Console.WriteLine("C is at position {0}", pos); // Outputs "C is at position 2"

            // completing a loop iteration early

            for (int j = 0; j <= 100; j++)
            {
                if ((j % 2) == 0) continue;
                Console.WriteLine(j);
            }

        }
    }
}
