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
             * DateTime constructors
             */

            Console.WriteLine(new DateTime(2015, 01, 14));
            Console.WriteLine(new DateTime(2014, 12, 10));
            Console.WriteLine(new DateTime(2000, 1, 2, 3, 4, 5));    // Date = 2 Jan 2000 03:04:05
            Console.WriteLine(new DateTime(2000, 1, 2, 3, 4, 5, 6)); // Date = 2 Jan 2000 03:04:05.0006
            Console.WriteLine(new DateTime(0));                      // 1 Jan 0001 (midnight)
            DateTime dateTime = new DateTime(630823790450000000);    // 2 Jan 2000 03:04:05
            Console.WriteLine(dateTime);
            Console.WriteLine(dateTime.Ticks);                       // 630823790450000000 - tick is a ten-milionth of a second or one hunder nanoseconds

            /**
             * String parsing
             */

            Console.WriteLine(DateTime.Parse("01/02/2006"));         // Date = 1 Feb 2006 (midnight)
            Console.WriteLine(DateTime.Parse("02/01/2000 03:04"));   // Date = 2 Jan 2000 03:04:00
            Console.WriteLine(DateTime.Parse("02/01/06"));           // Date = 2 Jan 2006 (midnight)

            /**
             * MinValue and MaxValue
             */

            Console.WriteLine(DateTime.MinValue);
            Console.WriteLine(DateTime.MaxValue);

            /**
             * .NET 2.0 Nullable DateTime
             */

            DateTime? nullableDateTime;
            nullableDateTime = DateTime.MinValue;
            Console.WriteLine(nullableDateTime);
            nullableDateTime = null;
            Console.WriteLine(nullableDateTime);
        }
    }
}
