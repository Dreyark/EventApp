using EventApp.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EventApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Event> Event { get; set; }
        public DbSet<Purpose> Purpose { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<AdminStatus> AdminStatus { get; set; }
    }
}
