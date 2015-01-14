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
            // goto statement

            Console.WriteLine("This will get outputted.");
            goto myLabel;
            Console.WriteLine("This will not get outputted.");

            myLabel:
                Console.WriteLine("This will get outputted too.");

            // goto and switch

            string statusCode = "Warn";

            switch (statusCode)
            {
                case "Warn":
                    Console.WriteLine("Completed with warnings.");
                    goto case "Complete";
                case "Err":
                    Console.WriteLine("Completed with errors.");
                    goto case "Complete";
                case "Complete":
                    Console.WriteLine("Completed.");
                    break;
                case "Fail":
                    Console.WriteLine("Failed to complete.");
                    break;
                default:
                    Console.WriteLine("Unknown status code");
                    goto case "Fail";

            }
        }
    }
}
