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
            // example of calling a method
            new Program().OutputFormattedDate();
        }

        void OutputFormattedDate()
        {
            DateTime theDate = DateTime.Now;
            Console.WriteLine(theDate.ToString("dd/MM/yyyy"));
        }
    }
}
