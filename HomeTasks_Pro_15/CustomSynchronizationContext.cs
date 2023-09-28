using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks_Pro_15
{
    internal class CustomSynchronizationContext : SynchronizationContext
    {
        public override void Post(SendOrPostCallback d, object state)
        {
           
            Thread newThread = new Thread(() =>
            {
                SetSynchronizationContext(this); 

                Console.WriteLine($"Потік з ім'ям '{Thread.CurrentThread.Name}', " +
                    $"ID={Thread.CurrentThread.ManagedThreadId}, " +
                    $"ThreadPoolThread={Thread.CurrentThread.IsThreadPoolThread}");
                d(state); 
            });

            newThread.Name = "Мій потік"; 
            newThread.Start();
        }
    }
    
}
