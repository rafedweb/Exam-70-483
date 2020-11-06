using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
    class Program
    {
        static void Task1()
        {
            Console.WriteLine("Task 1 starting");
            Thread.Sleep(2000);
            Console.WriteLine("Task 1 ending");
        }

        static void Task2()
        {
            Console.WriteLine("Task 2 starting");
            Thread.Sleep(1000);
            Console.WriteLine("Task 2 ending");
        }

        static void Main(string[] args)
        {
            //The Paralle.Invoke method can start alarge number of tasks at once. You have no controls over the order.
            Parallel.Invoke(() => Task1(), () => Task2());
            Console.WriteLine("Finished the processing. Press any key to end.");
            Console.ReadKey();
        }
    }
}
