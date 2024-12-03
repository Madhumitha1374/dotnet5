using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainInterviewPractice
{
    internal class EncapsulationPrac
    {
        private int _id;
        private string _name;
        private string _city;

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }

        public void display()
        {
            Console.WriteLine($"id : {_id} Name : {_name} city : {_city}");
        }
    }
}
