using System;
using System.Collections.Generic;
using System.Text;

namespace EducationManager.Data.Entities
{
    public class TimetableInClass
    {
        public int Timetable_Id { set; get; }
        public Timetable Timetable { get; set; }
        public int Class_Id { set; get; }
        public Class Class { get; set; }

    }
}
