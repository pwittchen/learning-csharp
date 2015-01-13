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
            // string data type
            string helloString = "hello string";
            Console.WriteLine(helloString);
            string nullString = null;
            string emptyString;
            emptyString = "";                       // emptyString is empty
            emptyString = String.Empty;             // emptyString is still empty
            Console.WriteLine(emptyString);
            helloString = "hello my string";        // string is immutable type - here object helloString is deleted and created once again
            Console.WriteLine(helloString);
            string repeating = new string('.', 15);
            Console.WriteLine(repeating);           // string constructor - repeating = "..............."
        }
    }
}
