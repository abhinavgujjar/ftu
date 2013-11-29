using FTU.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTU.DataAccess
{
    public interface IUniversityDataAccess
    {
        SemesterScore GetStudentScore(int studentId);

        List<SemesterScore> GetCollegeScores(int collegeId);

        List<int> GetColleges();
    }
}
