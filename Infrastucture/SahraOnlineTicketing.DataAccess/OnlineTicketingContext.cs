using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SahraOnlineTicketing.DataAccess.EntityConfiguration;
using SahraOnlineTicketing.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahraOnlineTicketing.DataAccess
{
    public class OnlineTicketingContext: DbContext
    {
        public IConfiguration _configuration { get; set; }
        public OnlineTicketingContext(DbContextOptions option, IConfiguration configuration) : base(option)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_configuration.GetConnectionString("OnlineTicketing"));
            }
        }

        public DbSet<Broker> Brokers { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<User> Users {get; set; }
        public DbSet<Role> Roles {get; set; }
        public DbSet<Ticket> Tickets {get; set; }
        public DbSet<State> States{get; set; }
        public DbSet<Priority> Priorities { get; set; }
        public DbSet<Attachment> Attachments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new BrokerConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new TicketConfiguration());
            modelBuilder.ApplyConfiguration(new StateConfiguration());
            modelBuilder.ApplyConfiguration(new PriorityConfigoration());
            modelBuilder.ApplyConfiguration(new AttachmentConfiguration());
        }
    }
}
