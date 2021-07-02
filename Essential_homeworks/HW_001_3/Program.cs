using System;

namespace HW_001_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Чистый код", "Стивен Макконелл", "Программирование");
            Console.WriteLine(book.Title.TitleOfBook);
            Console.WriteLine(book.Author.AuthorOfBook);
            Console.WriteLine(book.Content.ContentOfBook);
        }
    }
}
