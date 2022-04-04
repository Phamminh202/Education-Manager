using EducationManager.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationManager.Data.Configuration
{
    public class AttendanceReportConfiguration : IEntityTypeConfiguration<AttendanceReport>
    {
        public void Configure(EntityTypeBuilder<AttendanceReport> builder)
        {
            builder.ToTable("AttendanceReports");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Create_Date).HasDefaultValueSql("getdate()");

            builder.HasOne(b => b.Course).WithOne(i => i.Attendance_Report).HasForeignKey<AttendanceReport>(b => b.Course_Id);

        }
    }
}
