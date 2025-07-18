using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeManagement.Core.Model
{
    public  class Score
    {
        public int English { get; set; }
        public int Mathematics { get; set; }
        public int Chemistry { get; set; }
        public int Physics { get; set; }

        public Score(int english, int mathematic, int chemistry, int physics)
        {
            English = english;
            Mathematics = mathematic;
            Chemistry = chemistry;
            Physics = physics;
        }
        public int GradeCalculator()
        {
            int result = (English + Mathematics + Physics + Chemistry) / 4;
            return result;
        }
    }
}
