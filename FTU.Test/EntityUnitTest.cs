using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FTU.Entities;

namespace FTU.Test
{
    [TestClass]
    public class EntityUnitTest
    {
        [TestMethod]
        public void Test_Full_Name_Concatenation()
        {
            //Arrange
            var student = new Student();
            student.FirstName = "Akhil";
            student.LastName = "Singh";

            //act
            var fullName = student.FullName;

            //assert
            Assert.AreEqual("Akhil Singh", fullName);
        }

        [TestMethod]
        public void Test_LastName_IsNull()
        {
            //Arrange
            var student = new Student();
            student.FirstName = "Akhil";
            student.LastName = null;

            //act
            var fullName = student.FullName;

            //assert
            Assert.AreEqual("Akhil", fullName);

        }

        [TestMethod]
        public void Test_FirstName_IsNull()
        {
            //Arrange
            var student = new Student();
            student.FirstName = null;
            student.LastName = "Singh";

            //act
            var fullName = student.FullName;

            //assert
            Assert.AreEqual("Singh", fullName);

        }

        [TestMethod]
        public void Test_FirstName_And_LastName_AreNull()
        {
            //Arrange
            var student = new Student();
            student.FirstName = null;
            student.LastName = null;

            //act
            var fullName = student.FullName;

            //assert
            Assert.AreEqual("", fullName);
        }
    }
}
