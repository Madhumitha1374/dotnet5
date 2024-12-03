using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MultiThreading
{
    internal class Practice1
    {
        public void Even() {
            for (int i = 0; i < 50; i++)
            {
               if(i % 2 == 0)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine(i);
                }
            }
        }
        public void Odd()
        {
            for (int i = 0; i < 50; i++)
            {
                if (i % 2 != 0)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine(i);
                }
            }
        }
    }

}
