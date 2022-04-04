using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EducationManager.Data.EF
{
    public class EducationManagerDbContextFactory : IDesignTimeDbContextFactory<EducationManagerDbContext>
    {
        public EducationManagerDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("EducationManagerDb");

            var optionsBuilder = new DbContextOptionsBuilder<EducationManagerDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new EducationManagerDbContext(optionsBuilder.Options);
        }
    }
}
