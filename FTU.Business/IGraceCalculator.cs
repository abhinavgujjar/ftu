using System;
namespace FTU.Business
{
    interface IGraceCalculator
    {
        FTU.Entities.SemesterScore CalculateGrace(FTU.Entities.SemesterScore basescore);
    }
}
