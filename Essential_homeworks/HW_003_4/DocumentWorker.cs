using System;
using System.Collections.Generic;
using System.Text;

namespace Essential_003_4
{
    public class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про");
        }

        public virtual void Use()
        {
            this.OpenDocument();
            this.EditDocument();
            this.SaveDocument();
        }
    }
}
