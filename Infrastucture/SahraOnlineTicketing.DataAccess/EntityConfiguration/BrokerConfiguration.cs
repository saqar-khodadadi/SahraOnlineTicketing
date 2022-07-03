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
    public class BrokerConfiguration : IEntityTypeConfiguration<Broker>
    {
        public void Configure(EntityTypeBuilder<Broker> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(p => p.Title).HasMaxLength(40);
            builder.Property(p => p.Address).HasMaxLength(100);
            builder.Property(p => p.PhoneNumber).HasMaxLength(10);
            builder.Property(p => p.LogoUrl).HasMaxLength(100);
            builder.HasMany(a => a.Departments).WithOne(b => b.Broker);
        }
    }
}
