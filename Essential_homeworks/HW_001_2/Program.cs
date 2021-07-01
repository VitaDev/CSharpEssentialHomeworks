using System;

namespace HW_001_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину сторон прямоугольника");
            Console.Write("Сторона 1: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Сторона 2: ");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle = new Rectangle(side1, side2);
            Console.WriteLine($"Площадь прямоугольника: {rectangle.AreaCalculator()}");
            Console.WriteLine($"Периметр прямоугольника: {rectangle.PerimeterCalculator()}");
        }
    }
}
