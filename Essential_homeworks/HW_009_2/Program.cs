using System;

namespace HW_009_2
{
    class Program
    {
        delegate double Del(int x, int y);
        static void Main(string[] args)
        {
            bool exit = false;
            Console.WriteLine("Арифметические операции с использованием лямбда-выражений");
            do
            {
                Console.WriteLine("Введите два числа");
                Console.Write("x: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("y: ");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("1 - сложение, 2 - вычитание, 3 - умножение, 4 - деление, 5 - выход");
                int input = Convert.ToInt32(Console.ReadLine());
                Del del;
                switch (input)
                {
                    case 1:
                        del = (x, y) => { return x + y; };
                        Console.WriteLine(del(x, y));
                        break;
                    case 2:
                        del = (x, y) => { return x - y; };
                        Console.WriteLine(del(x, y));
                        break;
                    case 3:
                        del = (x, y) => { return x * y; };
                        Console.WriteLine(del(x, y));
                        break;
                    case 4:
                        del = (x, y) => { return Math.Round((double)x / y, 1); };
                        Console.WriteLine(del(x, y));
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Вы ввели неправильное значение!");
                        break;
                }
            } while (!exit);
        }
    }
}
