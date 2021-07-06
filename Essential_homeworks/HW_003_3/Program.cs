using System;

namespace HW_003_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Sedan", 4000, 200, 2006);
            Ship ship = new Ship(65, "Odessa", 13000, 30, 2009);
            Plane plane = new Plane(300, 105, 30000, 350, 2012);
            car.Show();
            Console.WriteLine(new String('-', 50));
            ship.Show();
            Console.WriteLine(new String('-', 50));
            plane.Show();
            Console.WriteLine(new String('-', 50));
        }
    }
}
