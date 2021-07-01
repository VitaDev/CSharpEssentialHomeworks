using System;
using System.Collections.Generic;
using System.Text;

namespace HW_001_2
{
    public class Rectangle
    {
        public Rectangle(double side1, double side2)
        {
            this.Side1 = side1;
            this.Side2 = side2;
        }
        public double Side1 { get; set; }
        public double Side2 { get; set; }

        public double AreaCalculator()
        {
            return this.Side1 * this.Side2;
        }
        public double PerimeterCalculator()
        {
            return (this.Side1 + this.Side2) * 2 ;
        }
    }
}
