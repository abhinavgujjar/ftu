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
            throw new NotImplementedException();
        }

        public int MaximumGracePerSubject
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int MaximumTotalGraceMarks
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
