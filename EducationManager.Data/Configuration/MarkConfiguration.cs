using EducationManager.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationManager.Data.Configuration
{
    public class MarkConfiguration : IEntityTypeConfiguration<Mark>
    {
        public void Configure(EntityTypeBuilder<Mark> builder)
        {
            builder.ToTable("Marks");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Marks).IsRequired();

            builder.HasOne(p => p.Class).WithMany(p => p.Marks).HasForeignKey(x => x.Class_Id);

            builder.HasOne(p => p.Academicyear).WithMany(p => p.Marks).HasForeignKey(x => x.Academicyear_Id);

            builder.HasOne(b => b.Course).WithOne(i => i.Mark).HasForeignKey<Mark>(b => b.Courser_Name);

            builder.HasOne(p => p.Semester).WithMany(p => p.Marks).HasForeignKey(b => b.Semester_Id);
        }
    }
}
