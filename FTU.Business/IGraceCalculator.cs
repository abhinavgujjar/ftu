using System;
namespace FTU.Business
{
    public interface IGraceCalculator
    {
        int MaximumGracePerSubject { get; set; }
        int MaximumTotalGraceMarks { get; set; }

        FTU.Entities.SemesterScore CalculateGrace(FTU.Entities.SemesterScore basescore);
    }
}
