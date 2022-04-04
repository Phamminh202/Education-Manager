using EducationManager.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationManager.Data.Configuration
{
    public class AcademicyearConfiguration : IEntityTypeConfiguration<Academicyear>
    {
        public void Configure(EntityTypeBuilder<Academicyear> builder)
        {
            builder.ToTable("Academicyears");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Name).IsRequired();
        }
    }
}
