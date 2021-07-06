using System;
using System.Linq;

namespace HW_005_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину массива: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[amount];
            Console.WriteLine("Заполните массив");
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Минимальное значение: {mas.Min()}"); 
            Console.WriteLine($"Максимальное значение: {mas.Max()}");
            Console.WriteLine($"Сумма: {mas.Sum()}");
            Console.WriteLine($"Среднее арифметическое: {mas.Sum()/amount}");
            Console.WriteLine("Нечётные значения:");
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] % 2 != 0)
                {
                    Console.WriteLine(mas[i]);
                }
            }
            Console.WriteLine(new String('-', 50));
        }
    }
}
