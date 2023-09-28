﻿namespace Task3
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            CustomSynchronizationContext synchronizationContext = new CustomSynchronizationContext();
            SynchronizationContext.SetSynchronizationContext(synchronizationContext);
      
            Console.WriteLine($"Головний потік: ID={Thread.CurrentThread.ManagedThreadId}, ThreadPoolThread={Thread.CurrentThread.IsThreadPoolThread}");

            int n = 5;
            Console.WriteLine($"Початок обчислення факторіала {n}");
      
            await Task.Run(() =>
            {
                Console.WriteLine($"Обчислення факторіала {n} у потоці: ID={Thread.CurrentThread.ManagedThreadId}, ThreadPoolThread={Thread.CurrentThread.IsThreadPoolThread}");

                int factorial = 1;
                for (int i = 1; i <= n; i++)
                {
                    factorial *= i;
                }

                Console.WriteLine($"Факторіал {n} = {factorial}");
            }).ConfigureAwait(true); 

            Console.WriteLine($"Завершення обчислення факторіала {n}");


        }
    }
}