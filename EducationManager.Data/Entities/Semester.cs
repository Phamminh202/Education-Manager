using System;
using System.Collections.Generic;
using System.Text;

namespace EducationManager.Data.Entities
{
    public class Semester
    {
        public int Id { set; get; }
        public string Name { set; get; }

        public List<Mark> Marks { set; get; }
        public StudentFee StudentFee { set; get; }
    }
}
