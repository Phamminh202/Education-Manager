using System;
using System.Collections.Generic;
using System.Text;

namespace EducationManager.Data.Entities
{
    public class TimetableInCourse
    {
        public int Timetable_Id { set; get; }
        public Timetable Timetable { get; set; }
        public int Course_Id { set; get; }
        public Course Course { get; set; }
    }
}
