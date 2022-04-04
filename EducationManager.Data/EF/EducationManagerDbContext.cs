using EducationManager.Data.Configuration;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure using Fluent API
            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());
            modelBuilder.ApplyConfiguration(new AcademicyearConfiguration());
            modelBuilder.ApplyConfiguration(new ApplicationConfiguration());
            modelBuilder.ApplyConfiguration(new AttendanceReportConfiguration());
            modelBuilder.ApplyConfiguration(new ClassConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new ExamConfiguration());
            modelBuilder.ApplyConfiguration(new MarkConfiguration());
            modelBuilder.ApplyConfiguration(new ParentConfiguration());
            modelBuilder.ApplyConfiguration(new StudentFeeConfiguration());
            modelBuilder.ApplyConfiguration(new TimetableConfiguration());

            modelBuilder.ApplyConfiguration(new TimetableInClassConfiguration());

            //base.OnModelCreating(modelBuilder);
        }

        public DbSet<Academicyear> Academicyears { set; get; }
        public DbSet<Application> Applications { set; get; }
        public DbSet<AttendanceReport> Attendance_Reports { set; get; }
        public DbSet<Class> Classes { set; get; }
        public DbSet<Course> Coursers { set; get; }
        public DbSet<Exam> Exams { set; get; }
        public DbSet<Mark> Marks { set; get; }
        public DbSet<Parent> Parents { set; get; }
        public DbSet<StudentFee> Student_Fees { set; get; }
        public DbSet<Timetable> Timetables { set; get; }

        public DbSet<TimetableInClass> TimetableInClasses { set; get; }

    }
}
