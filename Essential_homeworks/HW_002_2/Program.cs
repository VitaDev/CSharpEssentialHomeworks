using System;

namespace HW_002_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Personal personal = new Personal("Vladimir", "Bib");
            Console.WriteLine($"Имя: {personal.FirstName}\nФамилия: {personal.SecondName}\nДолжность: {personal.Position}\nЗарплата: {personal.RealSalary()}");
            Console.WriteLine(new String('-', 50));
            Maid maid = new Maid("Maria", "Sverskaya");
            Console.WriteLine($"Имя: {maid.FirstName}\nФамилия: {maid.SecondName}\nДолжность: {maid.Position}\nЗарплата: {maid.RealSalary()}");
            Console.WriteLine(new String('-', 50));
            SecurityGuard securityGuard = new SecurityGuard("Artem", "Pinkovskiy");
            Console.WriteLine($"Имя: {securityGuard.FirstName}\nФамилия: {securityGuard.SecondName}\nДолжность: {securityGuard.Position}\nЗарплата: {securityGuard.RealSalary()}");
            Console.WriteLine(new String('-', 50));
        }
    }
}
