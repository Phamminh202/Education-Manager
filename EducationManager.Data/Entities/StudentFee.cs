using System;
using System.Collections.Generic;
using System.Text;

namespace EducationManager.Data.Entities
{
    public class StudentFee
    {
        public int Id { set; get; }
        public int User_Id { set; get; }
        public int Semester_Id { set; get; }
        public Semester Semester { get; set; }

    }
}
