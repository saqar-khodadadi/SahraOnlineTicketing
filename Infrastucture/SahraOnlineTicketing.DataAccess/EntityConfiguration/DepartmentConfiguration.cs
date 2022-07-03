using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SahraOnlineTicketing.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahraOnlineTicketing.DataAccess.EntityConfiguration
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(p => p.Title).HasMaxLength(40);
            builder.HasMany(a => a.Users).WithOne(b => b.Department);
            builder.HasOne(a => a.Broker).WithMany(b => b.Departments).HasForeignKey(c=>c.BrokerId);

        }
    }
}
