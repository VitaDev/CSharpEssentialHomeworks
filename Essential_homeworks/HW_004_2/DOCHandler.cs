using System;
using System.Collections.Generic;
using System.Text;

namespace HW_004_2
{
    public class DOCHandler : AbstractHandler
    {
        public override void Create()
        {
            Console.WriteLine("Создание DOC-документа");
        }
        public override void Open()
        {
            Console.WriteLine("Открытие DOC-документа");
        }
        public override void Change()
        {
            Console.WriteLine("Изменение DOC-документа");
        }
        public override void Save()
        {
            Console.WriteLine("Сохранение DOC-документа");
        }
    }
}
