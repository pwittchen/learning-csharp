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
            // Check that a parameter was provided
            if (args.Length == 0)
            {
                throw new ArgumentException("A start-up parameter is required.");
            }

            Console.WriteLine("{0} argument(s) provided", args.Length);

            // re-throwing an exception

            try
            {
                // do operation
            }
            catch (Exception ex)
            {
                // Log the details of any exception and re-throw
                throw;
            }
        }
    }
}
