using System;
using System.Collections.Generic;

namespace EducationManager.Data.Models
{
    public partial class StudentFee
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SemesterId { get; set; }

        public virtual Semester Semester { get; set; }
        public virtual User User { get; set; }
    }
}
