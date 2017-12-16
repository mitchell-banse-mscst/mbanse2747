using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mbanseEx1b1.Models
{
    public class Student
    {
        private string lastName;
        public int ID { get; set; }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        // public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
