using System;
using System.Collections.Generic;

namespace EducationManager.Data.Models
{
    public partial class Class
    {
        public Class()
        {
            Mark = new HashSet<Mark>();
            Timetable = new HashSet<Timetable>();
            UserNavigation = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public string Classroom { get; set; }
        public int Qty { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Mark> Mark { get; set; }
        public virtual ICollection<Timetable> Timetable { get; set; }
        public virtual ICollection<User> UserNavigation { get; set; }
    }
}
