using System;
using System.Collections.Generic;

#nullable disable

namespace EducationManager.API.Models
{
    public partial class Class
    {
        public Class()
        {
            Marks = new HashSet<Mark>();
            Timetables = new HashSet<Timetable>();
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public string Classroom { get; set; }
        public int Qty { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Mark> Marks { get; set; }
        public virtual ICollection<Timetable> Timetables { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
