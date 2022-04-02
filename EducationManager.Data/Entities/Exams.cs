using System;
using System.Collections.Generic;
using System.Text;

namespace EducationManager.Data.Entities
{
    public class Exams
    {
        public int Id { set; get; }
        public DateTime Date { set; get; }
        public int Classroom { set; get; }
        public string Time { set; get; }
        
        public int User_Id { set; get; }
        public int Course_Id { set; get; }
    }
}
