using SahraOnlineTicketing.Domain.Base;

namespace SahraOnlineTicketing.Domain
{
    public class Broker:BaseEntity
    {
        public string Title { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string LogoUrl { get; set; }
        public virtual ICollection<Department> Departments { get; set; }    
    }
}