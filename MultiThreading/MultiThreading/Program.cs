using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MultiThreading
{
    internal class Program
    {
        static  void Main(string[] args)
        {
            version1 v = new version1();
            v.version();

            //a obj = new b();
            //a obj2 = new a();
            //a obj3 = new a();
            //var obj3 = new b();
            //var obj4 = new a();
            //b obj5 = new b();


            //Console.WriteLine("3124");
            //Console.WriteLine();

            //Console.WriteLine("12");
            //Console.WriteLine();


            //Console.WriteLine("3124");
            //Console.WriteLine();


            //Console.WriteLine("12");


            ////    Thread t = Thread.CurrentThread;
            ////    t.Name = "MainThread";
            ////    Console.WriteLine(t.Name); 


            //Thread1 thread1 = new Thread1();
            ////thread1.Print();
            //Thread t1 = new Thread(thread1.Print);
            //Thread t2 = new Thread(thread1.Print);
            //t1.Start();

            ////t1.Join();
            //// t1.Abort();
            //t2.Start();
            //t2.Suspend();


            Practice1 p1 = new Practice1();
            //p1.Even();
            //p1.Odd();

            //Console.WriteLine("----------");

            //Thread t = new Thread(p1.Even);
            //t.Start();
            //t.Suspend();
            //t.Join();

            //Thread t2 = new Thread(p1.Odd);
            //t2.Start();
            AsyncAwait a = new AsyncAwait();

            AsyncAwait.callMethod();


            Console.ReadLine();
        }
    }

    class a
    {
        static a()
        {
            Console.WriteLine("1");
        }

        public a()
        {

            Console.WriteLine("2");

        }



    }

    class b:a
    {
        static b()
        {
            Console.WriteLine("3");
        }

        public b()
        {

            Console.WriteLine("4");

        }



    }

}
