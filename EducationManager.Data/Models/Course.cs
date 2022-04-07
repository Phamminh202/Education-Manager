using System;
using System.Collections.Generic;

namespace EducationManager.Data.Models
{
    public partial class Course
    {
        public Course()
        {
            AttendanceReport = new HashSet<AttendanceReport>();
            Exams = new HashSet<Exams>();
            Mark = new HashSet<Mark>();
            Timetable = new HashSet<Timetable>();
            User = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Fee { get; set; }
        public string Description { get; set; }

        public virtual ICollection<AttendanceReport> AttendanceReport { get; set; }
        public virtual ICollection<Exams> Exams { get; set; }
        public virtual ICollection<Mark> Mark { get; set; }
        public virtual ICollection<Timetable> Timetable { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
