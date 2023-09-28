using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class CustomSynchronizationContext : SynchronizationContext
    {
        public override void Post(SendOrPostCallback d, object state)
        {
            try
            {
                d(state); 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error handled in CustomSynchronizationContext: {ex.Message}");
            }
        }
    }
}
