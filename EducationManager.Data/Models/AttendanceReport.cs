using System;
using System.Collections.Generic;

namespace EducationManager.Data.Models
{
    public partial class AttendanceReport
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CourseId { get; set; }
        public string Status { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual Course Course { get; set; }
        public virtual User User { get; set; }
    }
}
