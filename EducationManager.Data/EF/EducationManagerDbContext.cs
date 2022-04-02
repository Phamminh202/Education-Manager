using EducationManager.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationManager.Data.EF
{
    public class EducationManagerDbContext : DbContext
    {
        public EducationManagerDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Academicyear> Academicyears { set; get; }
        public DbSet<Application> Applications { set; get; }
        public DbSet<Attendance_report> Attendance_Reports { set; get; }
        public DbSet<Class> Classes { set; get; }
        public DbSet<Courser> Coursers { set; get; }
        public DbSet<Exams> Exams { set; get; }
        public DbSet<Mark> Marks { set; get; }
        public DbSet<Parent> Parents { set; get; }
        public DbSet<Student_fee> Student_Fees { set; get; }
        public DbSet<Timetable> Timetables { set; get; }

    }
}
