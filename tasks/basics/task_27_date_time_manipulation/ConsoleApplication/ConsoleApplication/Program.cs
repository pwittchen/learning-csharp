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
             * Addition and subtraction operators
             */

            DateTime theDate = DateTime.Parse("2 Jan 2007 20:15:00");

            // Add one hour, one minute and one second
            theDate = theDate + new TimeSpan(1, 1, 1);    // theDate = 2 Jan 2007 21:16:01
            Console.WriteLine(theDate);

            // Subtract twenty-five days
            theDate = theDate - new TimeSpan(25, 0, 0, 0);  // theDate = 8 Dec 2006 21:16:01
            Console.WriteLine(theDate);

            /**
             * Add methods
             */

            theDate = DateTime.Parse("2 Jan 2007 20:15:00");
            TimeSpan duration = TimeSpan.Parse("1.01:01:01");

            theDate = theDate.Add(duration);              // theDate = 3 Jan 2007 21:16:01
            Console.WriteLine(theDate);

            theDate = DateTime.Parse("2 Jan 2007");

            theDate = theDate.AddYears(1);                // theDate = 2 Jan 2008
            Console.WriteLine(theDate);
            theDate = theDate.AddMonths(2);               // theDate = 2 Mar 2008
            Console.WriteLine(theDate);
            theDate = theDate.AddDays(1.5);               // theDate = 3 Mar 2008 12:00:00
            Console.WriteLine(theDate);
            theDate = theDate.AddHours(-6);               // theDate = 2 Mar 2008 06:00:00
            Console.WriteLine(theDate);
            theDate = theDate.AddMinutes(150);            // theDate = 2 Mar 2008 08:30:00
            Console.WriteLine(theDate);
            theDate = theDate.AddSeconds(10.5);           // theDate = 2 Mar 2008 08:30:10.5
            Console.WriteLine(theDate);
            theDate = theDate.AddMilliseconds(499);       // theDate = 2 Mar 2008 08:30:10.999
            Console.WriteLine(theDate);
            theDate = theDate.AddTicks(10000);            // theDate = 2 Mar 2008 08:30:11
            Console.WriteLine(theDate);

            /**
             * Subtract method
             */

            theDate = DateTime.Parse("2 Jan 2007");
            TimeSpan subtract = TimeSpan.Parse("1.01:00:00");
            DateTime startDate = DateTime.Parse("1 Jan 2007");
            DateTime endDate = DateTime.Parse("2 Jan 2007 12:00:00");
            TimeSpan diff;

            // Subtract a TimeSpan from a DateTime
            theDate = theDate.Subtract(subtract);         // theDate = 31 Dec 2006 23:00:00
            Console.WriteLine(theDate);

            // Find the difference between two dates
            diff = endDate.Subtract(startDate);           // diff = 1.12:00:00
            Console.WriteLine(diff);

            /**
             * UTC and location DateTime conversion
             */

            DateTime localDate = DateTime.Parse("1 Jul 2007 12:00");
            Console.WriteLine(localDate);
            DateTime utcDate = localDate.ToUniversalTime();     // 1 Jul 2007 05:30
            Console.WriteLine(utcDate);
            DateTime utcToLocalTime = utcDate.ToLocalTime();    // 1 Jul 2007 12:00
            Console.WriteLine(utcToLocalTime);

            /**
             * Conversion from DateTime to string
             */

            theDate = DateTime.Parse("3 Jan 2007 21:25:30");

            Console.WriteLine(theDate.ToLongDateString());          // result = "03 January 2007"
            Console.WriteLine(theDate.ToShortDateString());         // result = "03/01/2007"
            Console.WriteLine(theDate.ToLongTimeString());          // result = "21:25:30"
            Console.WriteLine(theDate.ToShortTimeString());         // result = "21:25"


            /**
             * Using ToString with format specifiers
             */

            Console.WriteLine(theDate.ToString("d"));       // result = "03/01/2007"
            Console.WriteLine(theDate.ToString("f"));       // result = "03 January 2007 21:25"
            Console.WriteLine(theDate.ToString("y"));       // result = "January 2007"

            /**
             * Custom formatting
             */

            Console.WriteLine(theDate.ToString("d-MM-yy"));       // result = "3-01-07"
            Console.WriteLine(theDate.ToString("HH:mm"));         // result = "21:25"
            Console.WriteLine(theDate.ToString("h:mm tt"));       // result = "9:25 PM"

            /**
             * Formatting codes
             */

            Console.WriteLine(theDate.ToString("d"));
            Console.WriteLine(theDate.ToString("%d"));
        }
    }
}
