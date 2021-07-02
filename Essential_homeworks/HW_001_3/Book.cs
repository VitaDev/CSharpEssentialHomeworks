using System;
using System.Collections.Generic;
using System.Text;

namespace HW_001_3
{
    public class Book
    {
        public Book(string title, string author, string content)
        {
            Title = new Title { TitleOfBook = title };
            Author = new Author { AuthorOfBook = author };
            Content = new Content { ContentOfBook = content };
        }
        public Title Title { get; set; }
        public Author Author { get; set; }
        public Content Content { get; set; }
    }
}
