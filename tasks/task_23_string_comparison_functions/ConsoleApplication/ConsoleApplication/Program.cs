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
             * Equality and inequality operators
             */

            string s1 = "String to compare.";
            string s2 = "String to compare.";
            string s3 = "String to Compare.";   // Note the capital 'C'
            bool result;

            result = s1 == s2;                  // result = true
            Console.WriteLine(result);
            result = s1 == s3;                  // result = false
            Console.WriteLine(result);
            result = s1 != s2;                  // result = false
            Console.WriteLine(result);
            result = s1 != s3;                  // result = true
            Console.WriteLine(result);

            /**
             * Relative comparison
             */

            string animal1 = "Cat";
            string animal2 = "Dog";
            int resultTwo;

            resultTwo = animal1.CompareTo("Cat");          // result is zero
            Console.WriteLine(resultTwo);
            resultTwo = animal2.CompareTo("Cat");          // result is greater than zero
            Console.WriteLine(resultTwo);
            resultTwo = animal1.CompareTo(animal2);        // result is less than zero
            Console.WriteLine(resultTwo);

            /**
             * Compare method
             */

            resultTwo = String.Compare(animal1, "Cat");    // result is zero
            Console.WriteLine(resultTwo);
            resultTwo = String.Compare(animal2, "Cat");    // result is greater than zero
            Console.WriteLine(resultTwo);
            resultTwo = String.Compare(animal1, animal2);  // result is less than zero
            Console.WriteLine(resultTwo);

            /**
             * Null comparison
             */

            resultTwo = String.Compare(animal1, null);      // result is greater than zero
            Console.WriteLine(resultTwo);
            resultTwo = String.Compare(null, animal1);      // result is less than zero
            Console.WriteLine(resultTwo);
            resultTwo = String.Compare(null, null);         // result is zero
            Console.WriteLine(resultTwo);

            /**
             * Case sensitivity
             */

            animal1 = "Cat";
            animal2 = "cat";

            resultTwo = String.Compare(animal1, animal2, true);     // ignore case comparison
            Console.WriteLine(resultTwo);
            resultTwo = String.Compare(animal1, animal2, false);    // case sensitive comparison
            Console.WriteLine(resultTwo);

            /**
             * CompareOrdinal method
             */

            resultTwo = String.Compare(animal1, animal2);
            Console.WriteLine(resultTwo);
            resultTwo = String.CompareOrdinal(animal1, animal2);
            Console.WriteLine(resultTwo);

            /**
             * Equals Method
             */

            result = animal1.Equals("Cat");     // true
            Console.WriteLine(result);
            result = animal1.Equals("cat");     // false
            Console.WriteLine(result);

            /**
             * .NET 2.0 IsNullOrEmpty Method
             */

            animal1 = "Cat";
            animal2 = "";
            string animal3 = null;

            result = String.IsNullOrEmpty(animal1);     // false
            Console.WriteLine(result);
            result = String.IsNullOrEmpty(animal2);     // true
            Console.WriteLine(result);
            result = String.IsNullOrEmpty(animal3);     // true
            Console.WriteLine(result);
        }
    }
}
