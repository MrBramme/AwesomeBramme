using System;
using System.Threading.Tasks;

namespace Asyc.Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Async example");
            Console.WriteLine("---------------------------------------");
            RunAsyncExample();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Async example done");
            Console.WriteLine("Starting Parallell Example");
            Console.WriteLine("---------------------------------------");
            RunParallellExample(5);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Done, Press any key to exit ...");
            Console.ReadKey();
        }

        private static void RunAsyncExample()
        {
            var w1 = new Worker("worker 1");
            var w2 = new Worker("worker 2");
            var w3 = new Worker("worker 3");

            var task1 = w1.Run();
            var task2 = w2.Run();
            System.Threading.Thread.Sleep(3000);
            var task3 = w3.Run();

            Task.WhenAll(task1, task2, task3).Wait();

        }

        private static void RunParallellExample(int nr)
        {
            int[] arr = new int[nr];
            Random randNum = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = randNum.Next(100, 2000);
            }
            Parallel.ForEach(arr, (val) =>
            {
                Console.WriteLine($"{DateTime.Now:HH:mm:ss}: Starting '{val}' seconds sleep");
                System.Threading.Thread.Sleep(val);
                Console.WriteLine($"{DateTime.Now:HH:mm:ss}: Done sleeping '{val}'");
            });

        }
    }
}
