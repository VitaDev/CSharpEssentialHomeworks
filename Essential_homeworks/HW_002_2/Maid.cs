using System;
using System.Collections.Generic;
using System.Text;

namespace HW_002_2
{
    public class Maid : Employee
    {
        public Maid(string fname, string sname)
            : base(fname, sname)
        {
            this.WorkingTax = 15;
            this.Position = "Maid";
            this.Salary = 6500;
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
