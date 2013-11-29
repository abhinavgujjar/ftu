using System;
namespace FTU.Business
{
    public interface IGraceCalculator
    {
        int MaximumGracePerSubject { get; set; }
        int MaximumTotalGraceMarks { get; set; }
        int PassingScore { get; set; }

        FTU.Entities.SemesterScore CalculateGrace(FTU.Entities.SemesterScore basescore);
    }
}
