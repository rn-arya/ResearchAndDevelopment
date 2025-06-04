using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReseachAndDevelopment.AsyncAwait
{
    public class AsyncAwait
    {
        public static void MainMethod()

        {

            Console.WriteLine("Main Started...");

            PerformTaskAsync();

            //Main Started...
            //Task started...            
            //Main Completed...

           // PerformTaskAsync().Wait();
            //Main Started...
            //Task started...
            //Task completed!
            //Main Completed...

            //await PerformTaskAsync();
            //Main Started...
            //Task started...
            //Task completed!
            //Main Completed...
            Console.WriteLine("Main Completed...");

        }

        static async Task PerformTaskAsync()

        {

            Console.WriteLine("Task started...");

            await Task.Delay(1000);

            Console.WriteLine("Task completed!");

        }
    }
}
