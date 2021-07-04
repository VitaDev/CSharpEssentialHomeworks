using System;
using System.Collections.Generic;
using System.Text;

namespace HW_002_2
{
    public class SecurityGuard : Employee
    {
        public SecurityGuard(string fname, string sname)
            : base(fname, sname)
        {
            this.WorkingTax = 12;
            this.Position = "Security Guard";
            this.Salary = 9500;
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
