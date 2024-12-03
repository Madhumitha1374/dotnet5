using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainInterviewPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EncapsulationPrac p = new EncapsulationPrac();
            //p.Id = 1;
            //p.Name = "Madhu";
            //p.City = "Kadapa";
            //p.display();

           
            


            Sample s = new Sample();
            s.Method2();
            s.method();


            string s1 = "Madhu";
            s1.method1();

            Console.WriteLine("--------------------------");
            CompanyA c = new CompanyA();
            c.Header();
            c.Company_Info();
            c.Company_details();
            c.Date1();
            c.Footer();
            Console.WriteLine("---------------------------");

            DOc_Template x = new CompanyA();
            x.Header();
            x.Footer();
            x.Company_Info();
            x.Company_details();

            ChildB b = new ChildB();
            
            C1 c1 = new C1();
            c1.method1();
            //c1.i = 6;
            //c1.s = "Sanath";
            c1.method1();

            Console.WriteLine("--------------------------------");
            string s12 = "Madhu";
            string s13 = s12;
            string s14 = "Madhu";
            object s15 = s13;
            object s16 = "Madhu";

            Console.WriteLine(s12 == s13);
            Console.WriteLine(s12 == s14);
            Console.WriteLine(s13 == s14);

            Console.WriteLine(s12.Equals(s13));
            Console.WriteLine(s12.Equals(s14));
            Console.WriteLine(s13.Equals(s14));
            Console.WriteLine(s12.Equals(s15));
            Console.WriteLine(String.Compare(s12,s14));
            Console.WriteLine(String.Compare(s12,s13));

            Console.WriteLine(ReferenceEquals(s12,s13));
            Console.WriteLine(ReferenceEquals(s12,s14));
            Console.WriteLine(ReferenceEquals(s13,s14));
            Console.WriteLine(ReferenceEquals(s15,s14));
            Console.WriteLine(ReferenceEquals(s15, s16));

            Console.WriteLine("-----------------------------------");
            //string s1 = "Madhu";
            //string s2 = "Madhu";

            //object o1 = "Madhu";
            //object o2 = "Madhu";
            //Console.WriteLine(o1==o2);
            //Console.WriteLine(o1.Equals(o2));

            //Console.WriteLine(s1==s2);
            //Console.WriteLine(s1.Equals(s2));

            Console.ReadLine();
        }
    }
}
