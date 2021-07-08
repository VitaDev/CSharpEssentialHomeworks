using System;

namespace HW_005_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Article bread = new Article("Bread", "Kopiyka", 15.10, 1);
            Article bread2 = new Article("Bread2", "Kopiyka2", 16.10, 2);
            Article bread3 = new Article("Bread3", "Kopiyka3", 17.10, 3);
            Store store = new Store(bread, bread2, bread3);
            store.FindById(2);
            Console.WriteLine(new String('-', 50));
            store.FindByName("Bread");
        }
    }
}
