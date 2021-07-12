using System;

namespace HW_006_4
{
    class Program
    {
        public static int[] UpdateMassive(int[] mas, int newNumber)
        {
            int[] updatedMas = new int[mas.Length + 1];
            for (int i = 0; i < mas.Length; i++)
            {
                updatedMas[i] = mas[i];
            }
            updatedMas[updatedMas.Length - 1] = newNumber;
            for (int i = 0; i < updatedMas.Length-1; i++)
            {
                for (int j = i+1; j < updatedMas.Length; j++)
                {
                    if (updatedMas[j] < updatedMas[i])
                    {
                        int temp = updatedMas[i];
                        updatedMas[i] = updatedMas[j];
                        updatedMas[j] = temp;
                    }
                }
            }
            return updatedMas;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Расширяющийся целочисленный массив по возрастанию");
            int[] realMas = new int[0];
            bool exit = false;
            do
            {
                Console.WriteLine("Выберите один из пунктов: 1 - Добавить целочисленный элемент в массив, 2 - Просмотреть массив, 3 - Выход");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        {
                            Console.WriteLine("Введите целое число, которое хотите добавить в массив");
                            int number = Convert.ToInt32(Console.ReadLine());
                            int[] mas = Program.UpdateMassive(realMas, number);
                            realMas = mas;
                            break;
                        }
                    case 2:
                        {
                            string output = "";
                            foreach (var item in realMas)
                            {
                                output += item + ", ";
                            }
                            output = output.Substring(0, output.Length-2);
                            Console.WriteLine(output);
                            break;
                        }
                    case 3:
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
