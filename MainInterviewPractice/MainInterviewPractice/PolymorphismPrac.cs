using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainInterviewPractice
{
    internal class PolymorphismPrac
    {
        public void overLoading(int i, int j)
        {
            Console.WriteLine(i+j);
        }
        public void overLoading(double i, int j)
        {
            Console.WriteLine(i + j);
        }
        public void overLoading(int i, double j)
        {
            Console.WriteLine(i + j);
        }
        public void overLoading(ref int i,ref int j)
        {
            Console.WriteLine(i + j);
        }
        public void overLoading(int i, double j, int k)
        {
            Console.WriteLine(i + j + k);
        }

        public void overLoading(dynamic i, object j, object k)
        {
            Console.WriteLine(i + j + k);
        }


    }
}
