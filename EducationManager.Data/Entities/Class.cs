using System;
using System.Collections.Generic;
using System.Text;

namespace EducationManager.Data.Entities
{
    public class Class
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int User_Id { set; get; }
        public string Classroom { set; get; }
        public int Qty { set; get; }
    }
}
