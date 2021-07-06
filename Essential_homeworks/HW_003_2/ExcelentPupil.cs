using System;
using System.Collections.Generic;
using System.Text;

namespace HW_003_2
{
    public class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Учёба: Отлично!");
        }
        public override void Read()
        {
            Console.WriteLine("Чтение: Отлично!");
        }
        public override void Relax()
        {
            Console.WriteLine("Отдых: Плохо!");
        }
        public override void Write()
        {
            Console.WriteLine("Письмо: Отлично!");
        }
    }
}
