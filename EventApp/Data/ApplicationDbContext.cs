using EventApp.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EventApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Event> Event { get; set; }
        public DbSet<Purpose> Purpose { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<EventApp.Entities.Type> Type { get; set; }
        public DbSet<AdminStatus> AdminStatus { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Event>().HasMany(x => x.Purpose).WithMany(y => y.Events).UsingEntity(j => j.ToTable("EventPurpose"));
            base.OnModelCreating(builder);


            builder.Entity<Status>().HasData(
                new Status { Id = 1, Name = "Zaplanowany" },
                new Status { Id = 2, Name = "Wstrzymany" },
                new Status { Id = 3, Name = "Anulowany" },
                new Status { Id = 4, Name = "Zakoñczony" }
                );
            builder.Entity<AdminStatus>().HasData(
                new AdminStatus { Id = 1, Name = "Oczekuj¹ce" },
                new AdminStatus { Id = 2, Name = "Zaakceptowane" },
                new AdminStatus { Id = 3, Name = "Odrzucone" }
                );
            builder.Entity<Purpose>().HasData(
                new Purpose { Id = 1, Name = "Rozrywkowe" },
                new Purpose { Id = 2, Name = "Kulturalne" },
                new Purpose { Id = 3, Name = "Charytatywne" },
                new Purpose { Id = 4, Name = "Sportowe" },
                new Purpose { Id = 5, Name = "Biznesowe" }
                );
            builder.Entity<EventApp.Entities.Type>().HasData(
                new EventApp.Entities.Type { Id = 1, Name = "Koncert" },
                new EventApp.Entities.Type { Id = 2, Name = "Festyn" },
                new EventApp.Entities.Type { Id = 3, Name = "Wystawa" },
                new EventApp.Entities.Type { Id = 4, Name = "Targi" },
                new EventApp.Entities.Type { Id = 5, Name = "Zawody" }
                );
        }
    }
}
