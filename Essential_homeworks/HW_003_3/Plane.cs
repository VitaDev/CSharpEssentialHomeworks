using System;
using System.Collections.Generic;
using System.Text;

namespace HW_003_3
{
    public class Plane : Vehicle
    {
        public Plane(int height, int amountOfPassengers, double price, double speed, int yearOfIssue)
            : base(price, speed, yearOfIssue)
        {
            this.Height = height;
            this.AmountOfPassengers = amountOfPassengers;
        }
        public int Height { get; set; }
        public int AmountOfPassengers { get; set; }
        public void Show()
        {
            Console.WriteLine($"Высота: {Height}");
            Console.WriteLine($"Количество пассажиров: {AmountOfPassengers}");
            ShowVehicle();
        }
    }
}
