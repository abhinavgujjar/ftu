using System;
namespace FTU.Business
{
    public interface IGradeCalculator
    {
        FTU.Entities.Grade CalculateGrade(FTU.Entities.SemesterScore score);
    }
}
