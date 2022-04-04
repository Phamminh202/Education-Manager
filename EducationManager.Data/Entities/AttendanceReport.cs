using EducationManager.Data.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationManager.Data.Entities
{
    public class AttendanceReport
    {
        public int Id { set; get; }
        public int User_Id { set; get; }
        public int Course_Id { set; get; }
        public Status Status { set; get; }
        public DateTime Create_Date { set; get; }
        public Course Course { get; set; }
    }
}
