using System;
using System.Collections.Generic;
using System.Text;

namespace HW_002_2
{
    public class Employee
    {
        public Employee()
        {
        }
        public Employee(string fname, string sname)
        {
            FirstName = fname;
            SecondName = sname;
        }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
    }
}
