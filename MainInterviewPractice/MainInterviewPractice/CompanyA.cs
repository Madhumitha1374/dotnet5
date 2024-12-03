using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainInterviewPractice
{
    internal class CompanyA : DOc_Template
    {
        public override void Company_details()
        {
            Console.WriteLine("Lorem ipsum");
        }

        public override void Company_Info()
        {
            Console.WriteLine("Company A");
        }

        public  void  Date1()
        {
            Console.WriteLine("04-05-2009");
        }
    }
}
