using System;
using System.Collections.Generic;

#nullable disable

namespace EducationManager.API.Models
{
    public partial class Semester
    {
        public Semester()
        {
            Marks = new HashSet<Mark>();
            StudentFees = new HashSet<StudentFee>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Mark> Marks { get; set; }
        public virtual ICollection<StudentFee> StudentFees { get; set; }
    }
}
