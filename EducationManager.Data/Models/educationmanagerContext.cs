using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EducationManager.Data.Models
{
    public partial class educationmanagerContext : DbContext
    {
        public educationmanagerContext()
        {
        }

        public educationmanagerContext(DbContextOptions<educationmanagerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Academicyear> Academicyear { get; set; }
        public virtual DbSet<Action> Action { get; set; }
        public virtual DbSet<Application> Application { get; set; }
        public virtual DbSet<AttendanceReport> AttendanceReport { get; set; }
        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<Exams> Exams { get; set; }
        public virtual DbSet<Funtion> Funtion { get; set; }
        public virtual DbSet<Mark> Mark { get; set; }
        public virtual DbSet<Parent> Parent { get; set; }
        public virtual DbSet<Permissions> Permissions { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Semester> Semester { get; set; }
        public virtual DbSet<StudentFee> StudentFee { get; set; }
        public virtual DbSet<Timetable> Timetable { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Userrole> Userrole { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=PHAMMINH202;Database=educationmanager;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
                    .HasColumnName("Create_Date")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<AttendanceReport>(entity =>
            {
                entity.ToTable("attendance_report", "educationmanager");

                entity.HasIndex(e => e.CourseId)
                    .HasName("Course_Id");

                entity.HasIndex(e => e.UserId)
                    .HasName("User_Id");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CourseId).HasColumnName("Course_Id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("Create_Date")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.AttendanceReport)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("attendance_report$attendance_report_ibfk_1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AttendanceReport)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("attendance_report$attendance_report_ibfk_2");
            });

            modelBuilder.Entity<Class>(entity =>
            {
                entity.ToTable("class", "educationmanager");

                entity.HasIndex(e => e.UserId)
                    .HasName("User_Id");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Classroom)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Class)
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

            modelBuilder.Entity<Exams>(entity =>
            {
                entity.ToTable("exams", "educationmanager");

                entity.HasIndex(e => e.CourseId)
                    .HasName("Course_Id");

                entity.HasIndex(e => e.UserId)
                    .HasName("User_Id");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Classroom)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CourseId).HasColumnName("Course_Id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("Create_Date")
                    .HasColumnType("datetime2(0)");

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

                entity.HasIndex(e => e.AcademicyearId)
                    .HasName("Academicyear_Id");

                entity.HasIndex(e => e.ClassId)
                    .HasName("Class_Id");

                entity.HasIndex(e => e.CourserId)
                    .HasName("Courser_Id");

                entity.HasIndex(e => e.SemesterId)
                    .HasName("Semester_Id");

                entity.HasIndex(e => e.UserId)
                    .HasName("mark_ibfk_5");

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
                    .WithMany(p => p.Mark)
                    .HasForeignKey(d => d.AcademicyearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mark$mark_ibfk_1");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Mark)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mark$mark_ibfk_2");

                entity.HasOne(d => d.Courser)
                    .WithMany(p => p.Mark)
                    .HasForeignKey(d => d.CourserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mark$mark_ibfk_3");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.Mark)
                    .HasForeignKey(d => d.SemesterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mark$mark_ibfk_4");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Mark)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mark$mark_ibfk_5");
            });

            modelBuilder.Entity<Parent>(entity =>
            {
                entity.ToTable("parent", "educationmanager");

                entity.HasIndex(e => e.UserId)
                    .HasName("User_Id");

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
                    .WithMany(p => p.Parent)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("parent$parent_ibfk_1");
            });

            modelBuilder.Entity<Permissions>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("permissions", "educationmanager");

                entity.HasIndex(e => e.ActionId)
                    .HasName("permissions_ibfk_1");

                entity.HasIndex(e => e.FuntionId)
                    .HasName("permissions_ibfk_2");

                entity.HasIndex(e => e.RoleId)
                    .HasName("permissions_ibfk_3");

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

                entity.HasIndex(e => e.SemesterId)
                    .HasName("student_fee_ibfk_1");

                entity.HasIndex(e => e.UserId)
                    .HasName("User_Id");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.SemesterId).HasColumnName("Semester_Id");

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.StudentFee)
                    .HasForeignKey(d => d.SemesterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("student_fee$student_fee_ibfk_1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.StudentFee)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("student_fee$student_fee_ibfk_2");
            });

            modelBuilder.Entity<Timetable>(entity =>
            {
                entity.ToTable("timetable", "educationmanager");

                entity.HasIndex(e => e.ClassId)
                    .HasName("Class_Id");

                entity.HasIndex(e => e.CourseId)
                    .HasName("Course_Id");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ClassId).HasColumnName("Class_Id");

                entity.Property(e => e.CourseId).HasColumnName("Course_Id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("Create_Date")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Timetable)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("timetable$timetable_ibfk_1");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Timetable)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("timetable$timetable_ibfk_2");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user", "educationmanager");

                entity.HasIndex(e => e.ClassId)
                    .HasName("user_ibfk_1");

                entity.HasIndex(e => e.CourseId)
                    .HasName("user_ibfk_2");

                entity.HasIndex(e => e.ParentId)
                    .HasName("user_ibfk_3");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Avatar)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsFixedLength();

                entity.Property(e => e.ClassId).HasColumnName("Class_Id");

                entity.Property(e => e.CourseId).HasColumnName("Course_Id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("Create_date")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnName("Date_of_birth")
                    .HasColumnType("date");

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

                entity.HasOne(d => d.ClassNavigation)
                    .WithMany(p => p.UserNavigation)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user$user_ibfk_1");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user$user_ibfk_2");

                entity.HasOne(d => d.ParentNavigation)
                    .WithMany(p => p.UserNavigation)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user$user_ibfk_3");
            });

            modelBuilder.Entity<Userrole>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("userrole", "educationmanager");

                entity.HasIndex(e => e.RoleId)
                    .HasName("userrole_ibfk_1");

                entity.HasIndex(e => e.UserId)
                    .HasName("userrole_ibfk_2");

                entity.Property(e => e.RoleId).HasColumnName("Role_Id");

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Userrole)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("userrole$userrole_ibfk_1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Userrole)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("userrole$userrole_ibfk_2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
