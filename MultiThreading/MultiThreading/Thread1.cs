using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MultiThreading
{
    internal class Thread1
    {
        public void Print()
        {
            lock (this)
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(i);
                    //Thread.Sleep(100);
                }
            }

        }
    }
}
