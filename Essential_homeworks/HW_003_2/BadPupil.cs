using System;
using System.Collections.Generic;
using System.Text;

namespace HW_003_2
{
    public class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Учёба: Плохо!");
        }
        public override void Read()
        {
            Console.WriteLine("Чтение: Плохо!");
        }
        public override void Relax()
        {
            Console.WriteLine("Отдых: Лучше всех!");
        }
        public override void Write()
        {
            Console.WriteLine("Письмо: Плохо!");
        }
    }
}
