using System;
using System.Collections.Generic;
using System.Text;

namespace HW_002_2
{
    public class Personal : Employee
    {
        public Personal(string fname, string sname)
            : base(fname, sname)
        {
            this.WorkingTax = 10;
            this.Position = "Personal";
            this.Salary = 8000;
        }
        public string Position { get; set; }
        public double Salary { get; set; }
        public int WorkingTax { get; set; }
        public double RealSalary()
        {
            return Math.Round(Salary - Salary / WorkingTax);
        }
    }
}
