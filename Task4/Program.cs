namespace Task4
{
    internal class Program
    {
        static async void AsyncMethod()
        {
            Console.WriteLine("AsyncMethod started");
            await Task.Delay(1000);
            throw new Exception("Something went wrong in AsyncMethod");
        }

        static void Main()
        {
            var synchronizationContext = new CustomSynchronizationContext();
            SynchronizationContext.SetSynchronizationContext(synchronizationContext);
            AsyncMethod();
            Console.WriteLine("Program completed");
        }
    }
}