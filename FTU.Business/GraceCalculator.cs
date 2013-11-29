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
            var totalGrace = 0;
            foreach (var score in basescore.Scores)
            {
                var margin = (PassingScore - score.Score);
                if (totalGrace + margin <= MaximumTotalGraceMarks)
                {
                    if ((score.Score < PassingScore) && margin <= MaximumGracePerSubject)
                    {
                        totalGrace += margin;
                        score.Score = PassingScore;
                    }
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
