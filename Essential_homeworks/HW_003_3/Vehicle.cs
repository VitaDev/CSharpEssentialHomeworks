using System;
using System.Collections.Generic;
using System.Text;

namespace HW_003_3
{
    public class Vehicle
    {
        public Vehicle(double price, double speed, int yearOfIssue)
        {
            this.Price = price;
            this.Speed = speed;
            this.YearOfIssue = yearOfIssue;
        }
        public double Price { get; set; }
        public double Speed { get; set; }
        public int YearOfIssue { get; set; }

        public void ShowVehicle()
        {
            Console.WriteLine($"Стоимость: {Price}");
            Console.WriteLine($"Скорость: {Speed}");
            Console.WriteLine($"Год выпуска: {YearOfIssue}");
        }
    }
}
