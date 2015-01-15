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
            Program program = new Program();
            Console.WriteLine(program.GetFormattedDate());
            Console.WriteLine(program.GetArea(2, 4));
            Console.WriteLine(Program.GetAreaStatic(2, 4));
            
        }

        /**
         * method that returns value
         */
        private string GetFormattedDate()
        {
            DateTime theDate = DateTime.Now;
            return theDate.ToString("dd/MM/yyyy");
        }

        /**
         * mehtod with parameters
         */
        private int GetArea(int rectHeight, int rectWidth)
        {
            return rectHeight * rectWidth;
        }

        /**
         * static method
         */
        static int GetAreaStatic(int rectHeight, int rectWidth)
        {
            return rectHeight * rectWidth;
        }
    }
}
