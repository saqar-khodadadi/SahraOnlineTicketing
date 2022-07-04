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
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(p => p.Id);
            builder.HasOne(a => a.Role).WithMany(b => b.Users).HasForeignKey(c => c.RoleId);
            builder.Property(p => p.FirstName).HasMaxLength(30);
            builder.Property(p => p.FirstName).HasMaxLength(30);
            builder.Property(p => p.LastName).HasMaxLength(80);
            builder.Property(p => p.UserName).HasMaxLength(50);
            builder.Property(p => p.EmailAddress).HasMaxLength(150);
            builder.Property(p => p.PhoneNumber).HasMaxLength(10);
            builder.HasOne(a => a.Department).WithMany(b => b.Users).HasForeignKey(c => c.DepartmentId);
        }
    }
}
