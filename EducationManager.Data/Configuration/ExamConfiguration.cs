using EducationManager.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationManager.Data.Configuration
{
    public class ExamConfiguration : IEntityTypeConfiguration<Exam>
    {
        public void Configure(EntityTypeBuilder<Exam> builder)
        {
            builder.ToTable("Exams");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Create_Date).HasDefaultValueSql("getdate()");

            builder.HasOne(p => p.Course).WithMany(b => b.Exams).HasForeignKey(x => x.Course_Id);

        }
    }
}
