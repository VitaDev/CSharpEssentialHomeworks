using System;

namespace HW_002_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter convert = new Converter (27.3, 32.4, 0.37);
            Console.WriteLine(convert.ConvertToEur(30)); 
            Console.WriteLine(convert.ConvertToUsd(30)); 
            Console.WriteLine(convert.ConvertToRub(30)); 
            Console.WriteLine(convert.EurToGrivna(2)); 
            Console.WriteLine(convert.UsdToGrivna(2)); 
            Console.WriteLine(convert.RubToGrivna(2));
        }
    }
}
