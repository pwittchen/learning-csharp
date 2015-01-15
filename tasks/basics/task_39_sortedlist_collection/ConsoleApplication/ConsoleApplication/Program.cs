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
            // Creating Sorted List
            SortedList sortedList = new SortedList();
            SortedList sortedListWithCapacity = new SortedList(25);
            SortedList sortedListWithCaseSensitivity = new SortedList(new CaseInsensitiveComparer());
            SortedList sortedWithCapacityAndCaseSensitivity = new SortedList(new CaseInsensitiveComparer(), 25);

            // Copying data from hashtable
            Hashtable hashtable = new Hashtable();
            hashtable.Add("key1", "value1");
            SortedList sortedListWithContentsOfHashtable = new SortedList(hashtable, new CaseInsensitiveComparer());

            // Modifying SortedListContents
            // Adding items
            sortedList.Add("key1", "value1");
            // sortedList.Add("key1","value2"); // Duplicate: ArgumentException
            // sortedList.Add(null,"value3");   // Null Key : ArgumentNullException

            // Updating items using key
            sortedList["cabbage"] = "Red"; // adding new value
            sortedList["cabbage"] = "Savoy"; // updating added value
            sortedList.SetByIndex(1, "Late Flat Dutch"); // updating added value with index

            // Reading sortedList
            Console.WriteLine(sortedList.GetByIndex(0)); // get item by index
            Console.WriteLine(sortedList.GetKey(0));     // get key by index

            // Iterating using DictionaryEntry Objects
            foreach (DictionaryEntry entry in sortedList)
            {
                Console.WriteLine("{0}\t: {1}", entry.Key, entry.Value);
            }

            // Displaying values
            foreach (string value in sortedList.Values)
            {
                Console.WriteLine(value);
            }

            // Displaying keys
            foreach (string key in sortedList.Keys)
            {
                Console.WriteLine(key);
            }

            // GetValueList and GetKeyList methods
            IList keys = sortedList.GetKeyList();
            IList values = sortedList.GetValueList();

            // ContainsKey and ContainsValue
            Console.WriteLine("contains key 'key1': {0}", sortedList.ContainsKey("key1"));
            Console.WriteLine("contains key 'key2': {0}", sortedList.ContainsKey("key2"));
            Console.WriteLine("contains value 'value1': {0}", sortedList.ContainsValue("value1"));
            Console.WriteLine("contains value 'value2': {0}", sortedList.ContainsValue("value2"));

            // IndexOfKey and IndexOfValue
            Console.WriteLine("index of 'key1': {0}", sortedList.IndexOfKey("key1"));
            Console.WriteLine("index of 'key2': {0}", sortedList.IndexOfKey("key2"));
            Console.WriteLine("index of 'value1': {0}", sortedList.IndexOfValue("value1"));
            Console.WriteLine("index of 'value2': {0}", sortedList.IndexOfValue("value2"));

            // Creating a Thread-Safe SortedList Wrapper
            SortedList sortedListThreadSafe = SortedList.Synchronized(sortedList);
            Console.WriteLine("sortedListThreadSafe synchronized: {0}", sortedListThreadSafe.IsSynchronized);
        }
    }
}
