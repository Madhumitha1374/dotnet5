using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainInterviewPractice
{
    internal class ChildB : ParentA
    {
        public override void Method1A()
        {
            Console.WriteLine("Method1");
        }

        internal override void Method2V()
        {
            Console.WriteLine("Method 2 overrided");
        }

        public new void Method3()
        {
            Console.WriteLine("sdghkjkhjghgf");
        }



    }
}
