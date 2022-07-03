using SahraOnlineTicketing.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahraOnlineTicketing.Domain
{
    public class Department:BaseEntity
    {
        public string Title { get; set; }    
        public int BrokerId { get; set; }    
        public virtual Broker Broker { get; set; }    
        public virtual ICollection<User> Users { get; set; }    
    }
}
