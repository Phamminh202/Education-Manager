using System;
using System.Collections.Generic;

#nullable disable

namespace EducationManager.API.Models
{
    public partial class Course
    {
        public Course()
        {
            AttendanceReports = new HashSet<AttendanceReport>();
            Exams = new HashSet<Exam>();
            Marks = new HashSet<Mark>();
            Timetables = new HashSet<Timetable>();
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Fee { get; set; }
        public string Description { get; set; }

        public virtual ICollection<AttendanceReport> AttendanceReports { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
        public virtual ICollection<Mark> Marks { get; set; }
        public virtual ICollection<Timetable> Timetables { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
