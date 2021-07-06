using System;

namespace HW_004_2
{
    class Program
    {
        static void Main(string[] args)
        {
            XMLHandler xmlHandler = new XMLHandler();
            xmlHandler.AllMethods();
            Console.WriteLine(new String('-', 50));
            TXTHandler txtHandler = new TXTHandler();
            txtHandler.AllMethods();
            Console.WriteLine(new String('-', 50));
            DOCHandler docHandler = new DOCHandler();
            docHandler.AllMethods();
            Console.WriteLine(new String('-', 50));
        }
    }
}
