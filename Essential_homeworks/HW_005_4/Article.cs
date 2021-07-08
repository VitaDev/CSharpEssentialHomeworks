using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Linq;

namespace HW_005_4
{
    public class Article
    {
        public Article(string name, string shopName, double price, int id)
        {
            this.Name = name;
            this.ShopName = shopName;
            this.Price = price;
            this.Id = id;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShopName { get; set; }
        public double Price { get; set; }
        public void Show()
        {
            Console.WriteLine($"Id товара: {this.Id}");
            Console.WriteLine($"Название товара: {this.Name}");
            Console.WriteLine($"Название магазина, где находится товар: {this.ShopName}");
            Console.WriteLine($"Стоимость товара: {this.Price} грн");
        }
    }
}
