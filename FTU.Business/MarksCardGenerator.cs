using FTU.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTU.Business
{
    public class MarksCardGenerator : IMarksCardGenerator
    {
        public Entities.MarksCard GetMarksCard(int studentId)
        {
            //Using Mock
            var adjustedScores = GraceCalculator.CalculateGrace(null);

            var grade = GradeCalculator.CalculateGrade(adjustedScores);

            var aggregateScore = AggregateScores(adjustedScores);

            MarksCard card = new MarksCard()
            {
                StudentId = studentId,
                AggregateScore = aggregateScore,
                GradeAwarded = grade
                //Grade 
                //Percentage Calculation
            };

            return card;
        }

        private static int AggregateScores(SemesterScore adjustedScores)
        {
            var aggregateScore = 0;
            if (adjustedScores != null)
            {
                foreach (var subjectScore in adjustedScores.Scores)
                {
                    aggregateScore += subjectScore.Score;
                }
            }
            return aggregateScore;
        }

        public IGraceCalculator GraceCalculator
        {
            get; set;
        }

        public IGradeCalculator GradeCalculator
        {
            get;
            set;
        }

        public DataAccess.IUniversityDataAccess DataAccess
        {
            get;
            set;
        }
    }
}
