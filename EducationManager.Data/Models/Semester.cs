using System;
using System.Collections.Generic;

namespace EducationManager.Data.Models
{
    public partial class Semester
    {
        public Semester()
        {
            Mark = new HashSet<Mark>();
            StudentFee = new HashSet<StudentFee>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Mark> Mark { get; set; }
        public virtual ICollection<StudentFee> StudentFee { get; set; }
    }
}
