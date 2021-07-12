using System;

namespace HW_009_3
{
    class Program
    {
        delegate int MyDelegate();
        static void Main(string[] args)
        {
            Console.WriteLine("Среднее арифметическое значений делегатов");
            Random random = new Random();
            MyDelegate myDelegate = () => { return random.Next(1, 100); };
            myDelegate += () => { return random.Next(100, 1000); };
            myDelegate += () => { return random.Next(1000, 10000); };
            MyDelegate[] myDelegates = new MyDelegate[] { myDelegate, myDelegate, myDelegate };
            int sum = 0;
            int count = 0;
            foreach (var item in myDelegates)
            {
                sum += item();
                Delegate[] delegates = item.GetInvocationList();
                count += delegates.Length;
            }
            Console.WriteLine($"Среднее арифметическое: {Math.Round((double)sum/count, 1)}");
        }
    }
}
