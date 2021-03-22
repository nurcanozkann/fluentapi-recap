using CoreRecap.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreRecap.Data
{
    public class CourseConfig : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(k => k.CourseId);
            builder.Property(p=>p.CourseId).ValueGeneratedOnAdd();
            builder.Property(p => p.Credit).IsRequired();

            builder.HasOne(d => d.Department).WithMany(c => c.Courses).HasForeignKey(f=>f.DepartmentId);
        }
    }
}
