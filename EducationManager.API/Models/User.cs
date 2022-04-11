using System;
using System.Collections.Generic;

#nullable disable

namespace EducationManager.API.Models
{
    public partial class User
    {
        public User()
        {
            AttendanceReports = new HashSet<AttendanceReport>();
            Classes = new HashSet<Class>();
            Exams = new HashSet<Exam>();
            Marks = new HashSet<Mark>();
            Parents = new HashSet<Parent>();
            StudentFees = new HashSet<StudentFee>();
            Userroles = new HashSet<Userrole>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
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

        public virtual Class Class { get; set; }
        public virtual Course Course { get; set; }
        public virtual Parent Parent { get; set; }
        public virtual ICollection<AttendanceReport> AttendanceReports { get; set; }
        public virtual ICollection<Class> Classes { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
        public virtual ICollection<Mark> Marks { get; set; }
        public virtual ICollection<Parent> Parents { get; set; }
        public virtual ICollection<StudentFee> StudentFees { get; set; }
        public virtual ICollection<Userrole> Userroles { get; set; }
    }
}
