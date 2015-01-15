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
            // Creating HashTables
            Hashtable hashtable = new Hashtable();

            // HashTable can have capacity
            Hashtable hashtableWithCapacity = new Hashtable(100);

            /**
             * All hash tables have a load factor. 
             * This is the ratio between the number of items in the collection 
             * and the number of buckets, or storage spaces available. 
             * The load factor for a Hashtable dictionary defaults to 1.0 
             * to give a good balance between performance and memory requirements. 
             * The value may be altered in the constructor by specifying an initial capacity 
             * as an integer and a second, decimal parameter for the load factor. 
             * Valid values for the load factor are between 0.1 and 1.0. 
             * A value of 0.1 indicates that only one tenth of the storage space 
             * in the collection will be used before the Hashtable capacity is increased. 
             * This would give a high performing but memory-hungry dictionary.
             */
            Hashtable hashtableWithLoadFactor = new Hashtable(100, 0.1f);

            hashtable.Add("key1", "value1"); // adding new value to the hashtable
            //Hashtable hashtableCopy = new Hashtable(hashtable);
            //hashtable.Add("key1","value with duplicated key"); // Duplicate: ArgumentException
            //hashtable.Add(null,"value with null as a key");    // Null Key : ArgumentNullException

            // Updating using the key
            hashtable["apple"] = "Granny Smith";     // new item created
            hashtable["apple"] = "Golden Delicious"; // new item updated

            // Reading hashTable information
            Console.WriteLine(hashtable["apple"].ToString());

            // Iterating using DictionaryEntry Objects
            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine("{0} \t: {1}", entry.Key, entry.Value);
            }

            // Values
            foreach (string value in hashtable.Values)
            {
                Console.WriteLine(value);
            }

            // Keys
            foreach (string key in hashtable.Keys)
            {
                Console.WriteLine(key);
            }

            // ContainsKey

            Console.WriteLine("contains key 'key1': {0}", hashtable.ContainsKey("key1"));
            Console.WriteLine("contains key 'key2': {0}", hashtable.ContainsKey("key2"));

            // ContainsValue

            Console.WriteLine("contains value 'value1': {0}", hashtable.ContainsValue("value1"));
            Console.WriteLine("contains value 'value2': {0}", hashtable.ContainsValue("value2"));

            // Creating a Thread-Safe Hashtable Wrapper
            Hashtable hashtableThreadSafe = Hashtable.Synchronized(hashtable);
            Console.WriteLine("hashtableThreadSafe synchronised: {0}", hashtableThreadSafe.IsSynchronized);
        }
    }
}
