using System;
using System.Collections.Generic;
using System.Text;

namespace EducationManager.Data.Entities
{
    public class Course
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public decimal Fee { set; get; }
        public string Description { set; get; }
        public Mark Mark { get; set; }
        public AttendanceReport Attendance_Report { get; set; }
        public List<Exam> Exams { get; set; }
        public List<TimetableInCourse> TimetableInCourses { get; set; }
    }
}
