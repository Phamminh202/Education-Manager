using System;
using System.Collections.Generic;

namespace EducationManager.Data.Models
{
    public partial class Academicyear
    {
        public Academicyear()
        {
            Mark = new HashSet<Mark>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Mark> Mark { get; set; }
    }
}
