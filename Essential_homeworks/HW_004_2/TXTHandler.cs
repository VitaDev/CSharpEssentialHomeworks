using System;
using System.Collections.Generic;
using System.Text;

namespace HW_004_2
{
    public class TXTHandler : AbstractHandler
    {
        public override void Create()
        {
            Console.WriteLine("Создание TXT-документа");
        }
        public override void Open()
        {
            Console.WriteLine("Открытие TXT-документа");
        }
        public override void Change()
        {
            Console.WriteLine("Изменение TXT-документа");
        }
        public override void Save()
        {
            Console.WriteLine("Сохранение TXT-документа");
        }
    }
}
