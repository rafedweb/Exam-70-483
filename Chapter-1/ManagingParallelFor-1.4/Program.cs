using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ManagingParallelFor_1._4
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

            ParallelLoopResult result = Parallel.For(0, items.Count(), (int i, ParallelLoopState loopState) =>
            {
                if (i == 200)
                    loopState.Stop();

                WorkOnItem(items[i]);
            });

            Console.WriteLine("Completed: " + result.IsCompleted);
            Console.WriteLine("Items:" + result.LowestBreakIteration);

            Console.WriteLine("Finished processing. Press a key to end.");
            Console.ReadKey();
        }
    }
}
