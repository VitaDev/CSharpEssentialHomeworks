using System;
using System.Collections.Generic;
using System.Text;

namespace HW_003_3
{
    public class Ship : Vehicle
    {
        public Ship(int amountOfPassengers, string port, double price, double speed, int yearOfIssue)
            : base(price, speed, yearOfIssue)
        {
            this.AmountOfPassengers = amountOfPassengers;
            this.Port = port;
        }
        public int AmountOfPassengers { get; set; }
        public string Port { get; set; }
        public void Show()
        {
            Console.WriteLine($"Порт: {Port}");
            Console.WriteLine($"Количество пассажиров: {AmountOfPassengers}");
            ShowVehicle();
        }
    }
}
