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
        public int Semester { set; get; }
        public Status Status { set; get; }
        public DateTime Date { set; get; }

        public int Academicyear_Id { set; get; }
        public int Class_Id { set; get; }
        public string User_Name { set; get; }
        public string Courser_Name { set; get; }


    }
}
