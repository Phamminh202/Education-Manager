using System;
using System.Collections.Generic;

namespace EducationManager.Data.Models
{
    public partial class User
    {
        public User()
        {
            AttendanceReport = new HashSet<AttendanceReport>();
            Class = new HashSet<Class>();
            Exams = new HashSet<Exams>();
            Mark = new HashSet<Mark>();
            Parent = new HashSet<Parent>();
            StudentFee = new HashSet<StudentFee>();
            Userrole = new HashSet<Userrole>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public byte[] Avatar { get; set; }
        public int IdCard { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int ClassId { get; set; }
        public int CourseId { get; set; }
        public short Years { get; set; }
        public int ParentId { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual Class ClassNavigation { get; set; }
        public virtual Course Course { get; set; }
        public virtual Parent ParentNavigation { get; set; }
        public virtual ICollection<AttendanceReport> AttendanceReport { get; set; }
        public virtual ICollection<Class> Class { get; set; }
        public virtual ICollection<Exams> Exams { get; set; }
        public virtual ICollection<Mark> Mark { get; set; }
        public virtual ICollection<Parent> Parent { get; set; }
        public virtual ICollection<StudentFee> StudentFee { get; set; }
        public virtual ICollection<Userrole> Userrole { get; set; }
    }
}
