using System;
using System.Threading;

namespace ThreadPool1

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Id потока метода Main -{Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine("Zum starten - beliebige Taste drücken");
            Console.ReadKey();
            Report();
            ThreadPool.QueueUserWorkItem(new WaitCallback(Example1));
            Report();
            ThreadPool.QueueUserWorkItem(new WaitCallback(Example2));
            Report();
            Console.ReadKey();
            Report();

        }


        private static void Example1(object state)
        {
            Console.WriteLine($"Метод Example1 начал выполняться в потоке {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(2000);
            Console.WriteLine($"Метод Example1 закончил выполняться в потоке {Thread.CurrentThread.ManagedThreadId}");

        }

        private static void Example2(object state)
        {
            Console.WriteLine($"Метод Example2 начал выполняться в потоке {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(1000);
            Console.WriteLine($"Метод Example2 закончил выполняться в потоке {Thread.CurrentThread.ManagedThreadId}");

        }

        private static void Report()
        {
            ThreadPool.GetMaxThreads(out int maxWorkerThreads, out int maxPortThreads);
            ThreadPool.GetAvailableThreads(out int workerThreads, out int portThreads);

            Console.WriteLine($"Рабочие потоки {workerThreads} из {maxWorkerThreads}");
            Console.WriteLine($"IO потоки {maxPortThreads} из {maxPortThreads}");
            Console.WriteLine(new string('-', 80));
        }
    }
}
