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
            var items = Enumerable.Range(0, 500);
            //The Parallel.ForEach accepts two paramentes. 
            //The First paramenter is an IEnumerable collection. The second paramenter provides the action to be peformed on each item in the list.
            Parallel.ForEach(items, item =>
            {
                WorkOnItem(item);
            });

            Console.WriteLine("Finished processing. Press a key to end.");
            Console.ReadKey();
        }
    }
}
