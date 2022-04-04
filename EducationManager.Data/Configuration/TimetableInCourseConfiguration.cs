using EducationManager.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationManager.Data.Configuration
{
    public class TimetableInCourseConfiguration : IEntityTypeConfiguration<TimetableInCourse>
    {
        public void Configure(EntityTypeBuilder<TimetableInCourse> builder)
        {
            builder.ToTable("TimetableInCourse");

            builder.HasKey(x => new { x.Timetable_Id, x.Course_Id});

            builder.HasOne(p => p.Timetable).WithMany(b => b.TimetableInCourses).HasForeignKey(x => x.Timetable_Id);

            builder.HasOne(p => p.Course).WithMany(b => b.TimetableInCourses).HasForeignKey(x => x.Course_Id);

        }
    }
}
