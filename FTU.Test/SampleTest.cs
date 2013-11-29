using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTU.Test
{
    public interface IColorManager
    {
        string GetColor(int id);
    }

    public class ColorManager : IColorManager
    {
        string IColorManager.GetColor(int id)
        {
            switch (id)
            {
                case 1 :
                    return "Blue";
                case 2:
                    return "Red";
                case 3:
                    return "Yellow";
                default:
                    return "Black";
            }
            
        }
    }


    [TestClass]
    public class SampleTest
    {
        [TestMethod]
        public void testSomething()
        {
            var mockColorManager = new Mock<IColorManager>();
            mockColorManager.Setup(x => x.GetColor(5)).Returns("MAROON");
            mockColorManager.Setup(x => x.GetColor(20)).Returns("BEIGE");

            var coloManagerObject = (IColorManager)mockColorManager.Object; 

        }

    }
}
