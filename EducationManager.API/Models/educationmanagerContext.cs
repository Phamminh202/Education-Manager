using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EducationManager.API.Models
{
    public partial class educationmanagerContext : DbContext
    {
        /*public educationmanagerContext()
        {
        }*/

        public educationmanagerContext(DbContextOptions<educationmanagerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Academicyear> Academicyears { get; set; }
        public virtual DbSet<Action> Actions { get; set; }
        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<AttendanceReport> AttendanceReports { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<Funtion> Funtions { get; set; }
        public virtual DbSet<Mark> Marks { get; set; }
        public virtual DbSet<Parent> Parents { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Semester> Semesters { get; set; }
        public virtual DbSet<StudentFee> StudentFees { get; set; }
        public virtual DbSet<Timetable> Timetables { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Userrole> Userroles { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Academicyear>(entity =>
            {
                entity.ToTable("academicyear", "educationmanager");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Action>(entity =>
            {
                entity.ToTable("action", "educationmanager");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Application>(entity =>
            {
                entity.ToTable("application", "educationmanager");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CreateDate)
                    .HasPrecision(0)
                    .HasColumnName("Create_Date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<AttendanceReport>(entity =>
            {
                entity.ToTable("attendance_report", "educationmanager");

                entity.HasIndex(e => e.CourseId, "Course_Id");

                entity.HasIndex(e => e.UserId, "User_Id");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CourseId).HasColumnName("Course_Id");

                entity.Property(e => e.CreateDate)
                    .HasPrecision(0)
                    .HasColumnName("Create_Date");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.AttendanceReports)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("attendance_report$attendance_report_ibfk_1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AttendanceReports)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("attendance_report$attendance_report_ibfk_2");
            });

            modelBuilder.Entity<Class>(entity =>
            {
                entity.ToTable("class", "educationmanager");

                entity.HasIndex(e => e.UserId, "User_Id");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Classroom)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("class$class_ibfk_1");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("course", "educationmanager");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Fee).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Exam>(entity =>
            {
                entity.ToTable("exams", "educationmanager");

                entity.HasIndex(e => e.CourseId, "Course_Id");

                entity.HasIndex(e => e.UserId, "User_Id");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Classroom)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CourseId).HasColumnName("Course_Id");

                entity.Property(e => e.CreateDate)
                    .HasPrecision(0)
                    .HasColumnName("Create_Date");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Exams)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("exams$exams_ibfk_1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Exams)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("exams$exams_ibfk_2");
            });

            modelBuilder.Entity<Funtion>(entity =>
            {
                entity.ToTable("funtion", "educationmanager");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Mark>(entity =>
            {
                entity.ToTable("mark", "educationmanager");

                entity.HasIndex(e => e.AcademicyearId, "Academicyear_Id");

                entity.HasIndex(e => e.ClassId, "Class_Id");

                entity.HasIndex(e => e.CourserId, "Courser_Id");

                entity.HasIndex(e => e.SemesterId, "Semester_Id");

                entity.HasIndex(e => e.UserId, "mark_ibfk_5");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AcademicyearId).HasColumnName("Academicyear_Id");

                entity.Property(e => e.ClassId).HasColumnName("Class_Id");

                entity.Property(e => e.CourserId).HasColumnName("Courser_Id");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Mark1).HasColumnName("Mark");

                entity.Property(e => e.SemesterId).HasColumnName("Semester_Id");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.HasOne(d => d.Academicyear)
                    .WithMany(p => p.Marks)
                    .HasForeignKey(d => d.AcademicyearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mark$mark_ibfk_1");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Marks)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mark$mark_ibfk_2");

                entity.HasOne(d => d.Courser)
                    .WithMany(p => p.Marks)
                    .HasForeignKey(d => d.CourserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mark$mark_ibfk_3");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.Marks)
                    .HasForeignKey(d => d.SemesterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mark$mark_ibfk_4");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Marks)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mark$mark_ibfk_5");
            });

            modelBuilder.Entity<Parent>(entity =>
            {
                entity.ToTable("parent", "educationmanager");

                entity.HasIndex(e => e.UserId, "User_Id");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Job)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Parents)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("parent$parent_ibfk_1");
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.ToTable("permissions", "educationmanager");

                entity.HasIndex(e => e.ActionId, "permissions_ibfk_1");

                entity.HasIndex(e => e.FuntionId, "permissions_ibfk_2");

                entity.HasIndex(e => e.RoleId, "permissions_ibfk_3");

                entity.Property(e => e.ActionId).HasColumnName("Action_Id");

                entity.Property(e => e.FuntionId).HasColumnName("Funtion_Id");

                entity.Property(e => e.RoleId).HasColumnName("Role_Id");

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.Permissions)
                    .HasForeignKey(d => d.ActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("permissions$permissions_ibfk_1");

                entity.HasOne(d => d.Funtion)
                    .WithMany(p => p.Permissions)
                    .HasForeignKey(d => d.FuntionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("permissions$permissions_ibfk_2");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Permissions)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("permissions$permissions_ibfk_3");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("role", "educationmanager");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<Semester>(entity =>
            {
                entity.ToTable("semester", "educationmanager");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<StudentFee>(entity =>
            {
                entity.ToTable("student_fee", "educationmanager");

                entity.HasIndex(e => e.UserId, "User_Id");

                entity.HasIndex(e => e.SemesterId, "student_fee_ibfk_1");

                entity.Property(e => e.SemesterId).HasColumnName("Semester_Id");

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.StudentFees)
                    .HasForeignKey(d => d.SemesterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("student_fee$student_fee_ibfk_1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.StudentFees)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("student_fee$student_fee_ibfk_2");
            });

            modelBuilder.Entity<Timetable>(entity =>
            {
                entity.ToTable("timetable", "educationmanager");

                entity.HasIndex(e => e.ClassId, "Class_Id");

                entity.HasIndex(e => e.CourseId, "Course_Id");

                entity.Property(e => e.ClassId).HasColumnName("Class_Id");

                entity.Property(e => e.CourseId).HasColumnName("Course_Id");

                entity.Property(e => e.CreateDate)
                    .HasPrecision(0)
                    .HasColumnName("Create_Date");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Timetables)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("timetable$timetable_ibfk_1");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Timetables)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("timetable$timetable_ibfk_2");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user", "educationmanager");

                entity.HasIndex(e => e.ClassId, "user_ibfk_1");

                entity.HasIndex(e => e.CourseId, "user_ibfk_2");

                entity.HasIndex(e => e.ParentId, "user_ibfk_3");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Avatar)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsFixedLength(true);

                entity.Property(e => e.ClassId).HasColumnName("Class_Id");

                entity.Property(e => e.CourseId).HasColumnName("Course_Id");

                entity.Property(e => e.CreateDate)
                    .HasPrecision(0)
                    .HasColumnName("Create_date");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("date")
                    .HasColumnName("Date_of_birth");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.IdCard).HasColumnName("ID card");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.ParentId).HasColumnName("Parent_Id");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user$user_ibfk_1");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user$user_ibfk_2");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user$user_ibfk_3");
            });

            modelBuilder.Entity<Userrole>(entity =>
            {
                entity.ToTable("userrole", "educationmanager");

                entity.HasIndex(e => e.RoleId, "userrole_ibfk_1");

                entity.HasIndex(e => e.UserId, "userrole_ibfk_2");

                entity.Property(e => e.RoleId).HasColumnName("Role_Id");

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Userroles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("userrole$userrole_ibfk_1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Userroles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("userrole$userrole_ibfk_2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
