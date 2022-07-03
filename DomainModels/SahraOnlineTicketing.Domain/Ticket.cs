using SahraOnlineTicketing.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahraOnlineTicketing.Domain
{
    public class Ticket: BaseEntity
    {
        public string Title { get; set; }
        public int Code { get; set; }
        public string Message { get; set; }
        public int StateId { get; set; }
        public virtual State State { get; set; }
        public int PriorityId { get; set; }
        public virtual Priority Priority { get; set; }
        public virtual ICollection<Attachment> Attachments { get; set; }
    }
}
