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
            DateTime startDate = DateTime.Parse("30 Dec 2006");
            DateTime endDate = DateTime.Parse("1 Jan 2007");
            DateTime targetDate = DateTime.Parse("1 Jan 2007");

            /**
             * Equality and inequality operators
             */

            Console.WriteLine(startDate == endDate);      // result = false
            Console.WriteLine(targetDate == endDate);     // result = true
            Console.WriteLine(startDate != endDate);      // result = true
            Console.WriteLine(targetDate != endDate);     // result = false

            /**
             * Comparison operators
             */

            Console.WriteLine(startDate > endDate);        // result = false
            Console.WriteLine(startDate < endDate);        // result = true
            Console.WriteLine(startDate >= endDate);       // result = false
            Console.WriteLine(startDate <= endDate);       // result = true
            Console.WriteLine(targetDate > endDate);       // result = false
            Console.WriteLine(targetDate < endDate);       // result = false
            Console.WriteLine(targetDate >= endDate);      // result = true
            Console.WriteLine(targetDate <= endDate);      // result = true

            /**
             * Extraction of specific DateTime components
             */

            DateTime theDate = DateTime.Parse("30 Dec 2006 01:02:03.456 PM");

            Console.WriteLine(theDate.Year);         // year = 2006
            Console.WriteLine(theDate.Month);        // month = 12
            Console.WriteLine(theDate.Day);          // day = 30
            Console.WriteLine(theDate.Hour);         // hour = 13
            Console.WriteLine(theDate.Minute);       // minute = 2
            Console.WriteLine(theDate.Second);       // second = 3
            Console.WriteLine(theDate.Millisecond);  // millisecond = 456

            /**
             * Extraction of date or time
             */

            Console.WriteLine(theDate.Date);
            Console.WriteLine(theDate.TimeOfDay);

            /**
             * DayOfWeek property
             */

            DayOfWeek day = theDate.DayOfWeek;
            int dayNumber = (int)day;
            string dayString = day.ToString();
            Console.WriteLine(dayNumber);
            Console.WriteLine(dayString);

            /**
             * Day of year property
             */

            DateTime standard = DateTime.Parse("25 March 2006");
            DateTime leapyear = DateTime.Parse("25 March 2008");

            Console.WriteLine(standard.DayOfYear); // day = 84
            Console.WriteLine(leapyear.DayOfYear); // day = 85

            /**
             * Determining calendar information
             */

            Console.WriteLine(DateTime.DaysInMonth(2008, 2));   // 29
            Console.WriteLine(DateTime.IsLeapYear(2008));       // true
        }
    }
}
