using FTU.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTU.Business
{
    public class GraceCalculator : IGraceCalculator
    {
        public SemesterScore CalculateGrace(SemesterScore basescore)
        {
            foreach (var score in basescore.Scores)
            {
                if ((score.Score < PassingScore ) && (PassingScore - score.Score) <= MaximumGracePerSubject)
                {
                    score.Score = PassingScore;
                }
            }
            return basescore;
        }

        public int MaximumGracePerSubject
        {
            get ; set;
        }

        public int MaximumTotalGraceMarks
        {
            get; set;
        }

        public int PassingScore
        {
            get;
            set;
        }
    }
}
