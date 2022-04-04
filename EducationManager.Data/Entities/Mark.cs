using EducationManager.Data.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationManager.Data.Entities
{
     public class Mark
    {
        public int Id { set; get; }
        public decimal Marks { set; get; }
        public Status Status { set; get; }
        public DateTime Date { set; get; }

        public int Semester_Id { set; get; }
        public int Academicyear_Id { set; get; }
        public int Class_Id { set; get; }
        public string User_Name { set; get; }
        public string Courser_Name { set; get; }

        public Class Class { get; set; }
        public Course Course { get; set; }
        public Academicyear Academicyear { get; set; }
        public Semester Semester { get; set; }

    }
}
