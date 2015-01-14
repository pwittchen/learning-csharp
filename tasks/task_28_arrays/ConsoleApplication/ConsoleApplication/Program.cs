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
            // array declaration

            int[] items = new int[3];

            // index numbering

            items[0] = 25;
            items[1] = items[0] * 2;
            items[2] = items[1] * 2;

            // accessing data in array

            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }

            // two dimensional arrays

            string[,] table = new string[3, 4];

            table[0, 0] = "Apple";
            table[0, 1] = "Banana";
            table[0, 2] = "Clementine";
            table[0, 3] = "Damson";
            table[1, 0] = "Elderberry";
            table[1, 1] = "Fig";

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    var value = table[i, j];
                    if (!String.IsNullOrEmpty(value))
                    {
                        Console.WriteLine(value);
                    }
                }
            }

            // multidimensional arrays

            int[, ,] cube = new int[5, 4, 10];
            int[, , , ,] fiveDimensional = new int[1, 2, 3, 4, 5];

            // retrieving array size

            Console.WriteLine(fiveDimensional.Rank);
            Console.WriteLine(cube.Length);
            Console.WriteLine(cube.Rank);           // number of dimensions
            Console.WriteLine(cube.GetLength(0));   // length of the first dimension
            Console.WriteLine(cube.GetLength(1));   // length of the second dimension
            Console.WriteLine(cube.GetLength(2));   // length of the third dimension

            // Jagged arrays

            string[][] jaggedTable = new string[3][];   // Declare the main array

            // Declare each sub-array (row lengths)
            jaggedTable[0] = new string[] { "Apple", "Banana", "Clementine" };
            jaggedTable[1] = new string[] { "Cabbage", "Lettuce", "Onion", "Potato" };
            jaggedTable[2] = new string[] { "Cheese", "Milk" };

            // Test some values
            string fruit = jaggedTable[0][2];          // fruit = "Clementine"
            Console.WriteLine(fruit);
            string dairy = jaggedTable[2][1];          // dairy = "Milk"
            Console.WriteLine(dairy);

            // assigning and copying arrays

            int[] primary = new int[] { 2, 4, 8 };

            // Point a second array at the same memory range using assignment
            int[] secondary = primary;

            // Retrieve a value from the primary array
            int valueOfPrimary = primary[1];                 // value = 4
            Console.WriteLine(valueOfPrimary);

            // Alter the value in the secondary array and re-read the primary
            secondary[1] = 99;
            valueOfPrimary = primary[1];                     // value = 99
            Console.WriteLine(valueOfPrimary);

            // cloning arrays

            int[] primaryNext = new int[] { 2, 4, 8 };

            // Clone the array into a secondary array, casting appropriately
            int[] secondaryNext = (int[])primaryNext.Clone();

            // Retrieve a value from the primary array
            int valueNext = primaryNext[1];                 // value = 4
            Console.WriteLine(valueNext);

            // Alter the value in the secondary array and re-read the primary
            secondaryNext[1] = 99;
            valueNext = primaryNext[1];                     // value = 4
            Console.WriteLine(valueNext);
            valueNext = secondaryNext[1];                   // value = 99
            Console.WriteLine(valueNext);
        }
    }
}
