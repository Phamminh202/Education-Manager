using EducationManager.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationManager.Data.Configuration
{
    public class StudentFeeConfiguration : IEntityTypeConfiguration<StudentFee>
    {
        public void Configure(EntityTypeBuilder<StudentFee> builder)
        {
            builder.ToTable("StudentFees");

            builder.HasKey(x => x.Id);

            builder.HasOne(b => b.Semester).WithOne(i => i.StudentFee).HasForeignKey<StudentFee>(b => b.Semester_Id);

        }
    }
}
