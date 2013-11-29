using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTU.Entities
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearOfJoining { get; set; }
        public string Department { get; set; }
        public int CollegeId { get; set; }

        public string FullName
        {
            get { return FirstName + LastName; }
        }
    }
}
