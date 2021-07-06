using System;
using System.Collections.Generic;
using System.Text;

namespace HW_004_2
{
    public class AbstractHandler
    {
        public virtual void Create() { }
        public virtual void Open() { }
        public virtual void Change() { }
        public virtual void Save() { }

        public void AllMethods()
        {
            Create();
            Open();
            Change();
            Save();
        }
    }
}
