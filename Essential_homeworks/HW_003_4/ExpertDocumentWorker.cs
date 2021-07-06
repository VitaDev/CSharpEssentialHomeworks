using System;
using System.Collections.Generic;
using System.Text;

namespace Essential_003_4
{
    public class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }

        public override void Use()
        {
            this.OpenDocument();
            this.EditDocument();
            this.SaveDocument();
        }
    }
}
