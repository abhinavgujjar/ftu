using FTU.Business;
using FTU.DataAccess;
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
    public class MarksCardGenerationTest
    {
        [TestMethod]
        public void BasicTest()
        {
            //arrange 
            MarksCardGenerator gen = new MarksCardGenerator();

            var marksCard = gen.GetMarksCard(30);

            
        }
    }
}
