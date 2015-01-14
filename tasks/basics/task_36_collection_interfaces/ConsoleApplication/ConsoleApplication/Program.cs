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
            // boxing and uboxing

            int valueToBox = 123;
            object boxed = valueToBox;                      // Boxed
            int valueOutOfBox = (int)boxed;                 // Unboxed
            Console.WriteLine(valueOutOfBox);               // Outputs "123"

            // ICollection.CopyTo

            ArrayList names = new ArrayList();

            // Add some names
            names.Add("Andrew");
            names.Add("Alex");
            names.Add("Adrienne");

            // Copy the collection into a new array of strings
            string[] namesArray = new string[3];
            names.CopyTo(namesArray, 0);

            foreach (string name in namesArray)
            {
                Console.WriteLine(name);
            }

            // ICollection.Count

            Console.WriteLine(names.Count);

            // ICollection.IsSynchronized

            /*
             * When writing programs that are multi-threaded, 
             * it is possible that more than one thread of execution could access a collection simultaneously. 
             * If many threads are reading from and writing to a collection, unexpected problems could occur. 
             * To alleviate this problem collections may be synchronised. 
             * A synchronised (or synchronized) collection allows writing from multiple threads.
             */

            Console.WriteLine(names.IsSynchronized); // by default: false

            // ICollection.SyncRoot

            /*
             * The SyncRoot property returns an object that may be used for synchronisation for thread-safety. 
             * Even when a collection is synchronised there are situations where it is not thread-safe. 
             * For example, when looping, or enumerating, through a collection's items another thread may modify the collection. 
             * This causes an exception to be thrown. To guarantee thread-safety in this situation, 
             * the exceptions can be caught and handled or the collection may be locked using the SyncRoot object. 
             * Whilst locked, no other threads may access the collection.
             */

            lock (names.SyncRoot)
            {
                foreach (string name in names)
                {
                    Console.WriteLine(name);
                }
            }

            // IList interface
            /*
             * The IList interface declares the properties and methods of a collection that represents a list of numbered items. 
             * Each item in a list has a zero-based index that is similar to an array's index. 
             * It is not coincidental that arrays have this behaviour as they also implement the IList interface.
             */

            IList list = new ArrayList();

            // IList.Add

            Console.WriteLine("Count: {0}", names.Count);
            names.Add("Andrew");
            names.Add("Alex");
            int position = names.Add("Adrienne");
            Console.WriteLine(position);
            Console.WriteLine("Count: {0}", names.Count);

            // IList.Remove

            Console.WriteLine("Count: {0}", names.Count);
            names.Remove("Andrew");
            Console.WriteLine("Count: {0}", names.Count);

            // IList.Insert

            names.Insert(0, "Michelle");
            foreach (string name in names) Console.WriteLine(name);

            // IList.RemoveAt
            names.RemoveAt(1);

            // IList.Contains
            Console.WriteLine(names.Contains("Andrew"));

            // IList.IndexOf
            Console.WriteLine(names.IndexOf("Andrew"));

            // IList.IsFixedSize
            Console.WriteLine(names.IsFixedSize);

            // IList.IsReadOnly
            Console.WriteLine(names.IsReadOnly);

            // IList.Clear
            names.Clear();

            Console.WriteLine(names.Count);

            // IList.Item

            // Add some names
            names.Add("Andrew");
            names.Add("Alex");
            names.Add("Adrienne");

            Console.WriteLine(names[1]);
            names[1] = "Alan";
            Console.WriteLine(names[1]);

            // IDictionary.Add

            Hashtable users = new Hashtable();

            // Add some users
            users.Add("andyb", "Andrew Brown");
            users.Add("alexg", "Alex Green");
            users.Add("adrienneb", "Adrienne Black");

            Console.WriteLine(users.Count); // Outputs "3"

            // IDictionary.Remve
            users.Remove("andyb");

            // IDictionary.Contains
            users.Contains("alexg");

            // IDictionary.IsFixedSize and IDictionary.IsReadyOnly

            Console.WriteLine(users.IsFixedSize);
            Console.WriteLine(users.IsReadOnly);

            // IDictionary.Item
            Console.WriteLine(users["adrienneb"]);

            // IDictionary.Clear
            users.Clear();
            Console.WriteLine(users.Count);

            // IDictionary.Keys and IDictionary.Values

            // Extract the keys and values
            ICollection keys = users.Keys;
            ICollection values = users.Values;

            // Loop through each key and value
            foreach (object key in keys) Console.WriteLine(key);
            foreach (object value in values) Console.WriteLine(value);

            /**
             * In the above examples, the foreach command 
             * has been used to loop through the items in a collection. 
             * This is possible because the ICollection 
             * interface supports the IEnumerable interface.
             */
            
        }
    }
}
