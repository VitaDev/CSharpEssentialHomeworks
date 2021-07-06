using System;
using System.Collections.Generic;
using System.Text;

namespace HW_003_2
{
    public class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Учёба: Хорошо!");
        }
        public override void Read()
        {
            Console.WriteLine("Чтение: Хорошо!");
        }
        public override void Relax()
        {
            Console.WriteLine("Отдых: Хорошо!");
        }
        public override void Write()
        {
            Console.WriteLine("Письмо: Хорошо!");
        }
    }
}
