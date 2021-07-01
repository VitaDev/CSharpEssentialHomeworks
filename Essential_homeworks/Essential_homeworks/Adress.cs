using System;
using System.Collections.Generic;
using System.Text;

namespace HW_001_1
{
    public class Adress
    {
        public Adress()
        {
        }
        public Adress(int index, string country, string city, string street, string house, string apartment)
        {
            this.Index = index;
            this.Country = country;
            this.City = city;
            this.Street = street;
            this.House = house;
            this.Apartment = apartment;
        }
        public int Index { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }

        public void Output()
        {
            Console.WriteLine(this.Index);
            Console.WriteLine(this.Country);
            Console.WriteLine(this.City);
            Console.WriteLine(this.Street);
            Console.WriteLine(this.House);
            Console.WriteLine(this.Apartment);
        }
    }
}
