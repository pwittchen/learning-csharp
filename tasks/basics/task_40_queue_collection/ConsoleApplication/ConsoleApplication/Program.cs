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
            // Creating queue
            Queue queue = new Queue();
            Queue queueWithCapacity = new Queue(25);

            /**
             * By default, each time the capacity of a Queue is exceeded, 
             * the queue capacity doubles. This doubling occurs because 
             * the standard queue growth factor is 2. It is possible 
             * to adjust this multiplier when instantiating a Queue 
             * by passing a second, float parameter containing 
             * a growth factor between one and ten. On exceeding capacity, 
             * the current size is multiplied by this value.
             */

            Queue queueWithGrowthFactor = new Queue(10, 1.5f);

            ArrayList arrayList = new ArrayList();
            arrayList.Add("String 1");
            arrayList.Add("String 2");
            Queue queueWithCopyOfArray = new Queue(arrayList); // copies arrayList into queue

            // Using queue functions

            // Enqueue method
            Queue waitingQueue = new Queue();
            waitingQueue.Enqueue("Mrs Brown");
            waitingQueue.Enqueue("Mr Green");
            waitingQueue.Enqueue("Miss Black");
            Console.WriteLine("Count: {0}", waitingQueue.Count);

            // Dequeue method
            while (waitingQueue.Count != 0)
            {
                string next = waitingQueue.Dequeue().ToString();
                Console.WriteLine(next);
            }

            // Peek method
            waitingQueue.Enqueue("Mrs Brown");
            waitingQueue.Enqueue("Mr Green");
            waitingQueue.Enqueue("Miss Black");

            string nextWithPeek = waitingQueue.Peek().ToString();
            Console.WriteLine(nextWithPeek);
            Console.WriteLine("Count {0}", waitingQueue.Count);

            // Clear
            waitingQueue.Clear();

            // TrimToSize
            waitingQueue.TrimToSize();

            // Contains
            waitingQueue.Contains("test");

            // ToArray
            object[] array = waitingQueue.ToArray();

            // Creating Thread-Safe Queue Wrapper
            Queue threadSafeQueue = Queue.Synchronized(queue);
            Console.WriteLine(threadSafeQueue.IsSynchronized);
        }
    }
}
