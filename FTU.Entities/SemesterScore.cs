using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTU.Entities
{
    public class SemesterScore
    {
        public int SemesterId { get; set; }
        public int StudentId { get; set; }

        public int SemesterNumber { get; set; }

        //scores are out of hundred
        public List<SubjectScore> Scores { get; set; }
    }
}
