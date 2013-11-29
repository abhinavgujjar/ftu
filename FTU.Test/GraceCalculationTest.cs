using FTU.Business;
using FTU.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTU.Test
{
    [TestClass]
    public class GraceCalculationTest
    {
        GraceCalculator _calculator;

        public GraceCalculationTest()
        {
            _calculator = new GraceCalculator();
            _calculator.MaximumGracePerSubject = 2;
            _calculator.MaximumTotalGraceMarks = 5;
            _calculator.PassingScore = 50;

        }

        [TestMethod]
        public void Test_Any_One_Subject_Requires_Grace()
        {
            //arrange

            List<SubjectScore> scores = new List<SubjectScore>()
            {
                new SubjectScore { Score = 48, Subject = "Target" },
                new SubjectScore { Score = 60 },
                new SubjectScore { Score = 60 },
            };

            SemesterScore semScore = new SemesterScore()
            {
                 Scores = scores
            };

            //act

            var revisedScores = _calculator.CalculateGrace(semScore);

            //assertion
            var targetScore = revisedScores.Scores.Where(s => s.Subject == "Target").Single();
            Assert.AreEqual(50, targetScore.Score);

        }

        public void Test_Any_Subject_Score_less_than_48_other_above_50()
        {
        }

        [TestMethod]
        public void Test_All_Subject_Scores_More_than_PassingScore()
        {
            List<SubjectScore> scores = new List<SubjectScore>()
            {
                new SubjectScore { Score = 60 },
                new SubjectScore { Score = 60 },
                new SubjectScore { Score = 60 },
            };

            SemesterScore semScore = new SemesterScore()
            {
                Scores = scores
            };

            //act

            var revisedScores = _calculator.CalculateGrace(semScore);

            //assertion
            foreach (var revisedScore in revisedScores.Scores)
            {
                Assert.AreEqual(60, revisedScore.Score);
            }
        }

        public void Test_Two_Subject_Scores_Are_48_Others_More_Than_50()
        {
        }

        [TestMethod]
        public void Test_All_Are_48()
        {
            List<SubjectScore> scores = new List<SubjectScore>()
            {
                new SubjectScore { Score = 48 },
                new SubjectScore { Score = 48 },
                new SubjectScore { Score = 48 },
            };

            SemesterScore semScore = new SemesterScore()
            {
                Scores = scores
            };

            //act

            var revisedScores = _calculator.CalculateGrace(semScore);

            //assertion
            var numberOfPasses =
                revisedScores.Scores.Where(r => r.Score >= 50).Count();
            
            Assert.AreEqual(2, numberOfPasses);
        }

        public void Test_All_Subject_Less_Than_48()
        {
        }

        public void Test_Two_Subject_Scores_Are_48_And_one_49()
        {
        }

        public void Test_47_49_49()
        {
            List<SubjectScore> scores = new List<SubjectScore>()
            {
                new SubjectScore { Score = 47 },
                new SubjectScore { Score = 49 },
                new SubjectScore { Score = 49 },
            };

            SemesterScore semScore = new SemesterScore()
            {
                Scores = scores
            };

            //act

            var revisedScores = _calculator.CalculateGrace(semScore);

            //assertion
            var numberOfPasses =
                revisedScores.Scores.Where(r => r.Score >= 50).Count();


            var sameScore =
                revisedScores.Scores.Where(r => r.Score == 47).Count();
            
            Assert.AreEqual(2, numberOfPasses);
            Assert.AreEqual(1, numberOfPasses);

        }

        [TestMethod]
        public void Test_48_48_49()
        {
            List<SubjectScore> scores = new List<SubjectScore>()
            {
                new SubjectScore { Score = 48 },
                new SubjectScore { Score = 48 },
                new SubjectScore { Score = 49 },
            };

            SemesterScore semScore = new SemesterScore()
            {
                Scores = scores
            };

            //act

            var revisedScores = _calculator.CalculateGrace(semScore);

            //assertion
            var numberOfPasses =
                revisedScores.Scores.Where(r => r.Score >= 50).Count();


            Assert.AreEqual(3, numberOfPasses);

        }

    }
}
