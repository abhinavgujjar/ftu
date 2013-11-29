using System;
namespace FTU.Business
{
    interface IGradeCalculator
    {
        FTU.Entities.Grade CalculateGrade(FTU.Entities.SemesterScore score);
    }
}
