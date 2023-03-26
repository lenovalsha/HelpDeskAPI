using HelpDeskAPINew.Models;
using Microsoft.EntityFrameworkCore;

namespace HelpDeskAPINew.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        public DataContext()
        {
        }

        public DbSet<Priority> Priorities { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Status> Statuses { get; set; }
        //public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketChat> TicketChats { get; set; }
        public DbSet<UserTicket> UserTickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("server=localhost;database=HelpDeskNew;user id=sa;password=P@ssword!;encrypt=false");
            options.EnableSensitiveDataLogging();
        }

        public DbSet<HelpDeskAPINew.Models.Admin>? Admin { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        public DbSet<HelpDeskAPINew.Models.Ticket>? Ticket { get; set; }





    }
}
