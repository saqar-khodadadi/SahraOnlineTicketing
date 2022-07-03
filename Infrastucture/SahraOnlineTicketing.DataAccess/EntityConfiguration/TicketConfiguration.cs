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
    internal class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(p => p.Title).HasMaxLength(40);
            builder.Property(p => p.Title).HasMaxLength(1000);
            builder.HasOne(a => a.Priority).WithMany(b => b.Tickets).HasForeignKey(c=>c.PriorityId);
            builder.HasOne(a => a.Priority).WithMany(b => b.Tickets).HasForeignKey(c => c.PriorityId);
            builder.HasMany(a => a.Attachments).WithOne(b => b.Ticket);
        }
    }
}
