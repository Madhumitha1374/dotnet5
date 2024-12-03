using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainInterviewPractice
{
    abstract class DOc_Template
    {
        public void Header()
        {
            Console.WriteLine("Intralinks");
        }

        public void Footer()
        {
            Console.WriteLine("Established in 1999");
        }

        public abstract void Company_Info();
        public abstract void Company_details();


    }
}
