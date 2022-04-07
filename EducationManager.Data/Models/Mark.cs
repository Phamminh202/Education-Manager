using System;
using System.Collections.Generic;

namespace EducationManager.Data.Models
{
    public partial class Mark
    {
        public int Id { get; set; }
        public int Mark1 { get; set; }
        public int SemesterId { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
        public int AcademicyearId { get; set; }
        public int ClassId { get; set; }
        public int UserId { get; set; }
        public int CourserId { get; set; }

        public virtual Academicyear Academicyear { get; set; }
        public virtual Class Class { get; set; }
        public virtual Course Courser { get; set; }
        public virtual Semester Semester { get; set; }
        public virtual User User { get; set; }
    }
}
