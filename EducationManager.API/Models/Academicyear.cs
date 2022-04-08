using System;
using System.Collections.Generic;

#nullable disable

namespace EducationManager.API.Models
{
    public partial class Academicyear
    {
        public Academicyear()
        {
            Marks = new HashSet<Mark>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Mark> Marks { get; set; }
    }
}
