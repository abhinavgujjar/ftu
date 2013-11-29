using FTU.DataAccess;
using System;
namespace FTU.Business
{
    interface IMarksCardGenerator
    {
        IGraceCalculator GraceCalculator { get; set; }
        IGradeCalculator GradeCalculator { get; set; }
        IUniversityDataAccess DataAccess { get; set; }

        FTU.Entities.MarksCard GetMarksCard(int p);
    }
}
