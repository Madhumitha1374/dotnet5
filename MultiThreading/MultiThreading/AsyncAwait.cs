using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading
{
    internal class AsyncAwait
    {
        //run this with only method2
        //public static  async Task Method1()
        //{
        //    await Task.Run(() =>
        //    {
        //        for (int i = 0; i < 100; i++)
        //        {
        //            Console.WriteLine("Method 1");
        //            Task.Delay(1000).Wait();
        //        }
        //    });
        //}
        //public static void Method2()
        //{
        //        for (int i = 0; i < 100; i++)
        //        {
        //            Console.WriteLine("Method 2");
        //            Task.Delay(1000).Wait();
        //        }
        //}

        //this is for method 3
        public static async Task<int> Method1()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("Method 1");
                    Task.Delay(100).Wait();
                    count += 1;
                }
            });
            return count;
        }

        public static void Method3(int count)
        {
            Console.WriteLine("Count is : " + count);

        }

        public static async Task callMethod()
        {
            var count = await AsyncAwait.Method1();
            AsyncAwait.Method3(count);
        }

      
    }
}
