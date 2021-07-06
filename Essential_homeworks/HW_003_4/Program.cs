using System;

namespace Essential_003_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать DocumentWorker!");
            Console.WriteLine("Введите ключ от версии Pro или Expert. Если отсутствует ключ, введите 1");
            string input = Console.ReadLine();
            if (Equals(input, "1"))
            {
                DocumentWorker documentWorker = new DocumentWorker();
                documentWorker.Use();
            }
            else if (Equals(input, "pro"))
            {
                ProDocumentWorker proDocumentWorker = new ProDocumentWorker();
                proDocumentWorker.Use();
            }
            else if (Equals(input, "expert"))
            {
                ExpertDocumentWorker expertDocumentWorker = new ExpertDocumentWorker();
                expertDocumentWorker.Use();
            }
            else
            {
                Console.WriteLine("Неверный ввод");
            }
        }
    }
}
