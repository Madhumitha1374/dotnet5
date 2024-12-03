using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainInterviewPractice
{
    abstract class ParentA
    {
        public abstract void Method1A();
        internal virtual void Method2V()
        {
            Console.WriteLine("Method2");
        }
        
        public void Method3()
        {
            Console.WriteLine("Method 3");
        }


    }
}
