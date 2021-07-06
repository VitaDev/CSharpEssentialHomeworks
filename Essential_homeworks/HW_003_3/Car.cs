using System;
using System.Collections.Generic;
using System.Text;

namespace HW_003_3
{
    public class Car : Vehicle
    {
        public Car(string typeofcar, double price, double speed, int yearOfIssue)
            : base(price, speed, yearOfIssue)
        {
            this.TypeOfCar = typeofcar;
        }
        public string TypeOfCar { get; set; }
        public void Show()
        {
            Console.WriteLine($"Тип машины: {TypeOfCar}");
            ShowVehicle();
        }
    }
}
