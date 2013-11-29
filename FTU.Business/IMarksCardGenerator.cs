using System;
namespace FTU.Business
{
    interface IMarksCardGenerator
    {
        FTU.Entities.MarksCard GetMarksCard(int p);
    }
}
