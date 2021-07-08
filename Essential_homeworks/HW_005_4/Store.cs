using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW_005_4
{
    public class Store
    {
        public Store(params Article[] mas)
        {
            Articles = new List<Article>();
            foreach (var item in mas)
            {
                Articles.Add(item);
            }
        }

        private List<Article> Articles;

        public void FindById(int id)
        {
            Article article = Articles.FirstOrDefault(art => art.Id == id);
            if (!Equals(article, null))
            {
                article.Show();
            }
            else Console.WriteLine("Товар не найден!");
        }
        public void FindByName(string name)
        {
            Article article = Articles.Where(a => a.Name.StartsWith(name)).FirstOrDefault();
            if (!Equals(article, null))
            {
                article.Show();
            }
            else Console.WriteLine("Товар не найден!");
        }
    }
}
