using System;
using System.Collections.Generic;
using System.Text;

namespace HW_003_2
{
    public class ClassRoom
    {
        Random random = new Random();

        public List<Pupil> Pupils { get; set; }

        public ClassRoom(Pupil p1, Pupil p2)
        {
            Pupils = new List<Pupil>();
            Pupils.Add(p1);
            Pupils.Add(p2);
            Pupils.Add(GeneratePupil());
            Pupils.Add(GeneratePupil());
        }

        public ClassRoom(Pupil p1, Pupil p2, Pupil p3)
        {
            Pupils = new List<Pupil>();
            Pupils.Add(p1);
            Pupils.Add(p2);
            Pupils.Add(p3);
            Pupils.Add(GeneratePupil());
        }

        public ClassRoom(Pupil p1, Pupil p2, Pupil p3, Pupil p4)
        {
            Pupils = new List<Pupil>();
            Pupils.Add(p1);
            Pupils.Add(p2);
            Pupils.Add(p3);
            Pupils.Add(p4);
        }

        private Pupil GeneratePupil()
        {
            int rand = random.Next(1, 3);

            switch (rand)
            {
                case 1: return new ExcelentPupil();
                case 2: return new GoodPupil();
                case 3: return new BadPupil();
                default: return new BadPupil();
            }
        }
    }
}
