using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainInterviewPractice
{
    static class ExtensionMethod
    {
        public static void method(this Sample s)
        {
            //s += "Sagar";
            Console.WriteLine(s);
        }
    }

    static class ExtensionMethod1
    {
        public static void method1(this String s)
        {
            s += "Sagar";
            Console.WriteLine(s);
        }
    }
    internal class Sample
    {
        public void Method2()
        {
            string x = "Madhumitha";
           // x.method();
        }
    }
}
