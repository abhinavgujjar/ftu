using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTU.Entities
{
    public class MarksCard
    {
        public int StudentId { get; set; }
        public Grade GradeAwarded { get; set; }
        public decimal ScorePercentage { get; set; }
        public int AggregateScore { get; set; }
    }
}
