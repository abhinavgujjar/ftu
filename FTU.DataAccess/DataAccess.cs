using FTU.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTU.DataAccess
{
    public class RealDataAccess : IUniversityDataAccess
    {
        public Entities.SemesterScore GetStudentScore(int studentId)
        {
            throw new NotImplementedException();
        }

        public List<Entities.SemesterScore> GetCollegeScores(int collegeId)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudents()
        {
            return new List<Student>(){
                new Student { FirstName = "aaaa" },
                new Student { FirstName = "bbbb" },
                new Student { FirstName = "cccc" },
                new Student { FirstName = "dddd" }
            };
        }

        public List<int> GetColleges()
        {
            throw new NotImplementedException();
        }
    }
}
