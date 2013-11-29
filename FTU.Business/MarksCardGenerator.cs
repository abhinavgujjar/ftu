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
            var rawScores = DataAccess.GetStudentScore(studentId);

            var adjustedScores = GraceCalculator.CalculateGrace(rawScores);

            var grade = GradeCalculator.CalculateGrade(adjustedScores);

            MarksCard card = new MarksCard()
            {
                StudentId = studentId
                //AggregateScore = 
                //Grade 
                //Percentage Calculation
            };

            return card;
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
