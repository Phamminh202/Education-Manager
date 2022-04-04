using EducationManager.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationManager.Data.Configuration
{
    public class TimetableInClassConfiguration : IEntityTypeConfiguration<TimetableInClass>
    {       
        public void Configure(EntityTypeBuilder<TimetableInClass> builder)
        {
            builder.ToTable("TimetableInClass");

            builder.HasKey(x => new { x.Timetable_Id,x.Class_Id});

            builder.HasOne(p => p.Timetable).WithMany(b => b.TimetableInClasses).HasForeignKey(x => x.Timetable_Id);

            builder.HasOne(p => p.Class).WithMany(b => b.TimetableInClasses).HasForeignKey(x => x.Class_Id);

        }
    }
}
