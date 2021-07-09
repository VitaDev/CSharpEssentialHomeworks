using System;
using System.Collections.Generic;
using System.Text;

namespace HW_006_2
{
    static class FindAndReplaceManager
    {
        public static string text = "This book is unusual for two reasons.";
        public static bool FindNext(string str) 
        {
            return text.Contains(str);
        }
    }
}
