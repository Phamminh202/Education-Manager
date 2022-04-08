using System;
using System.Collections.Generic;

#nullable disable

namespace EducationManager.API.Models
{
    public partial class Timetable
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int ClassId { get; set; }
        public int CourseId { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual Class Class { get; set; }
        public virtual Course Course { get; set; }
    }
}
