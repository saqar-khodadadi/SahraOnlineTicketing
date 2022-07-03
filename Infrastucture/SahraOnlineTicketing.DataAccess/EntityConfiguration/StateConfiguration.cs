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
    internal class StateConfiguration : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(p => p.Title).HasMaxLength(40);
            builder.HasMany(a => a.Tickets).WithOne(b => b.State);
        }
    }
}
