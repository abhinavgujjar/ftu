using FTU.Business;
using FTU.DataAccess;
using FTU.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTU.Test
{
    [TestClass]
    public class MarksCardGenerationTest
    {
        [TestMethod]
        public void BasicTest()
        {

            //60, 50 ,50 

            //ARRANGE
            MarksCardGenerator marksCarGenerator = new MarksCardGenerator();

            var mockGraceCalculator = new Mock<IGraceCalculator>();
            SemesterScore inputScore = new SemesterScore()
            {
                Scores = new List<SubjectScore>()
                 {
                      new SubjectScore() { Score = 60 },
                      new SubjectScore() { Score = 50 },
                      new SubjectScore() { Score = 40 }

                 }
            };

            mockGraceCalculator.Setup(
                foo => foo.CalculateGrace(It.IsAny<SemesterScore>())).
                Returns(inputScore);


            marksCarGenerator.GraceCalculator = mockGraceCalculator.Object;

            var mockGradeCalclator = new Mock<IGradeCalculator>();

            marksCarGenerator.GradeCalculator = mockGradeCalclator.Object;

            
            var marksCard = marksCarGenerator.GetMarksCard(30);

            Assert.AreEqual(150, marksCard.AggregateScore);
        }

        [TestMethod]
        public void GradeTest()
        {

            //60, 50 ,50 

            //ARRANGE
            MarksCardGenerator marksCarGenerator = new MarksCardGenerator();

            var mockGraceCalculator = new Mock<IGraceCalculator>();
            marksCarGenerator.GraceCalculator = mockGraceCalculator.Object;

            var mockGradeCalclator = new Mock<IGradeCalculator>();
            mockGradeCalclator.Setup(foo => foo.CalculateGrade(It.IsAny<SemesterScore>())).Returns(Grade.FirstClass);

            marksCarGenerator.GradeCalculator = mockGradeCalclator.Object;


            var marksCard = marksCarGenerator.GetMarksCard(30);

            Assert.AreEqual(Grade.FirstClass, marksCard.GradeAwarded);
        }
    }
}
