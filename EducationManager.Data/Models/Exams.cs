﻿using System;
using System.Collections.Generic;

namespace EducationManager.Data.Models
{
    public partial class Exams
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Classroom { get; set; }
        public TimeSpan Time { get; set; }
        public DateTime CreateDate { get; set; }
        public int UserId { get; set; }
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
        public virtual User User { get; set; }
    }
}
