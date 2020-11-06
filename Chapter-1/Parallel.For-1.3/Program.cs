using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
    class Program
    {
        static void WorkOnItem(object item)
        {
            Console.WriteLine("Start working on: " + item);
            Thread.Sleep(1000);
            Console.WriteLine("Finished working on " + item);
        }

        static void Main(string[] args)
        {
            var items = Enumerable.Range(0, 500).ToArray();
            
            Parallel.For(0, items.Length, i =>
            {
                WorkOnItem(items[i]);
            });

            Console.WriteLine("Finished processing. Press a key to end.");
            Console.ReadKey();
        }
    }
}
