using System;

namespace HW_003_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcelentPupil excelentPupil = new ExcelentPupil();
            GoodPupil goodPupil = new GoodPupil();
            BadPupil badPupil = new BadPupil();
            BadPupil badPupil2 = new BadPupil();
            ClassRoom classRoom = new ClassRoom(excelentPupil, goodPupil, badPupil, badPupil2);
            foreach (var item in classRoom.Pupils)
            {
                Console.WriteLine($"Ученик №{classRoom.Pupils.IndexOf(item)+1}");
                item.Study();
                item.Read();
                item.Write();
                item.Relax();
                Console.WriteLine(new String('-', 50));
            }
        }
    }
}
