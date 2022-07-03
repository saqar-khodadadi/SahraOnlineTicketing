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
    public class AttachmentConfiguration : IEntityTypeConfiguration<Attachment>
    {
        public void Configure(EntityTypeBuilder<Attachment> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(p => p.Url).HasMaxLength(600);
            builder.HasOne(a => a.Ticket).WithMany(b => b.Attachments).HasForeignKey(p => p.TicketId);
        }
    }
}
