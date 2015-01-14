using System;
using System.Collections;
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
            // ArrayList Constructors
            ArrayList myCollection = new ArrayList();

            string[] fruitArray = new string[] { "Apple", "Banana", "Grape" };

            ArrayList fruitCollection = new ArrayList(fruitArray);

            // List collection items
            foreach (string fruit in fruitCollection) Console.WriteLine(fruit);

            ArrayList myCollectionTwo = ArrayList.Repeat("Item", 5);

            // List collection items
            foreach (string s in myCollectionTwo) Console.WriteLine(s);

            // Adding Multiple Items

            ArrayList myCollectionThree = ArrayList.Repeat("Item", 3);
            ArrayList extraItems = ArrayList.Repeat("Extra", 2);

            // Add extra items
            myCollectionThree.AddRange(extraItems);

            // List collection items
            foreach (string s in myCollectionThree) Console.WriteLine(s);

            // Add extra items

            ArrayList myCollectionFour = ArrayList.Repeat("Item", 3);
            myCollectionThree.InsertRange(1, extraItems);

            // List collection items
            foreach (string s in myCollectionFour) Console.WriteLine(s);

            // Removing multiple items
            ArrayList myCollectionFive = ArrayList.Repeat("Item", 6);

            // Remove three items starting with the first item in the ArrayList
            myCollectionFive.RemoveRange(0, 3);

            // List collection items
            foreach (string s in myCollectionFive) Console.WriteLine(s);

            // Replacing multiple items

            ArrayList myCollectionSix = ArrayList.Repeat("Item", 5);
            ArrayList newItems = ArrayList.Repeat("New", 2);

            // Overwrite items
            myCollectionSix.SetRange(1, newItems);

            // List collection items
            foreach (string s in myCollectionSix) Console.WriteLine(s);

            // Reversing ArrayList Items

            ArrayList myCollectionSeven = new ArrayList(new string[] { "One", "Two", "Three", "Four", "Five" });

            // Reverse items
            myCollectionSeven.Reverse();

            // List collection items
            foreach (string s in myCollectionSeven) Console.WriteLine(s);

            // Querying items - retrieving an index

            ArrayList myCollectionEight = new ArrayList(new string[] { "One", "Two", "Find Me", "Three", "Find Me", "Four", "Find Me", "Five" });

            int location = -1;

            do
            {
                location = myCollectionEight.IndexOf("Find Me", location + 1);
                if (location != -1)
                {
                    Console.WriteLine("Found at index {0}", location);
                }
            }
            while (location != -1);

            Console.WriteLine(myCollectionEight.IndexOf("One", 1, 3));      // Outputs -1
            Console.WriteLine(myCollectionEight.IndexOf("Three", 1, 3));    // Outputs 2
            Console.WriteLine(myCollectionEight.IndexOf("Five", 1, 3));     // Outputs -1
            Console.WriteLine(myCollectionEight.LastIndexOf("One"));        // Outputs 0
            Console.WriteLine(myCollectionEight.LastIndexOf("One", 3, 3));  // Outputs -1

            // Sorting

            ArrayList myCollectionNine = new ArrayList(new string[] { "One", "Two", "Three", "Four", "Five" });

            // Sort items
            myCollection.Sort();

            // List collection items
            foreach (string s in myCollectionNine) Console.WriteLine(s);

            // Extracting range of values

            ArrayList myCollectionTen = new ArrayList(new string[] { "One", "Two", "Three", "Four", "Five" });

            // Extract items
            ArrayList extract = myCollectionTen.GetRange(1, 3);

            // List collection items
            foreach (string s in extract) Console.WriteLine(s);

            // Copying an ArrayList

            ArrayList myCollectionEvelen = new ArrayList(new string[] { "One", "Two", "Three", "Four", "Five" });
            string[] arrayEleven = new string[5];

            // Copy items
            myCollectionEvelen.CopyTo(arrayEleven);

            // List array items
            foreach (string s in arrayEleven) Console.WriteLine(s);

            // ArrayList Capacity

            ArrayList myCollectionTwelve = new ArrayList();

            int capacity = myCollectionTwelve.Capacity;
            Console.WriteLine("Default capacity is {0} items", capacity);

            myCollectionTwelve.Capacity = 40;
            capacity = myCollectionTwelve.Capacity;
            Console.WriteLine("New capacity is {0} items", capacity);

            // ArrayList Wrappers

            ArrayList myCollectionThirteen = new ArrayList(new string[] { "One", "Two", "Three", "Four", "Five" });

            ArrayList myFixed = ArrayList.FixedSize(myCollectionThirteen);

            Console.WriteLine(myFixed.IsFixedSize);     // Outputs "True"

            // myFixed.Add("Six");                      // Throws a NotSupportedException

            // Creating Read-Only ArrayList

            ArrayList myCollectionFourteen = new ArrayList(new string[] { "One", "Two", "Three", "Four", "Five" });
            ArrayList myReadOnly = ArrayList.ReadOnly(myCollectionFourteen);

            Console.WriteLine(myReadOnly.IsFixedSize);  // Outputs "True"
            Console.WriteLine(myReadOnly.IsReadOnly);   // Outputs "True"

            // myReadOnly[0] = "Apple";                 // Throws a NotSupportedException

            // Creating Synchronised ArrayList

            ArrayList myCollectionFifteen = new ArrayList(new string[] { "One", "Two", "Three", "Four", "Five" });
            ArrayList myThreadSafe = ArrayList.Synchronized(myCollectionFifteen);
            Console.WriteLine(myThreadSafe.IsSynchronized); // Outputs "True"

            // Providing ArrayList Functionality to Other IList Classes

            string[] numbers = new string[] { "One", "Two", "Three", "Four", "Five" };
            ArrayList wrapper = ArrayList.Adapter(numbers);

            // Sort the ArrayList and underlying array
            wrapper.Sort();

            // List wrapper items
            foreach (string s in wrapper) Console.WriteLine(s);

            // Perform a search
            Console.WriteLine("'One' found at index {0}", wrapper.BinarySearch("One"));
        }
    }
}
