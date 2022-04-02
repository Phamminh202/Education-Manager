using EducationManager.Data.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationManager.Data.Entities
{
    public class Attendance_report
    {
        public int user_id { set; get; }
        public int course_id { set; get; }
        public Status status { set; get; }
    }
}
