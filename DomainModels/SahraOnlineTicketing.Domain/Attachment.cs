using SahraOnlineTicketing.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahraOnlineTicketing.Domain
{
    public class Attachment: BaseEntity
    {
        public string Url { get; set; }
        public int TicketId { get; set; }
        public virtual Ticket Ticket { get; set; }
    }
}
