using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.EF
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Link> Links { get; set; } = null!;

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            Link link_1 = new() { Id = Guid.NewGuid(), LongURl = "https://learn.javascript.ru/", ShortURL = "learn.javascript.ru", Date = DateTime.Now, VisitsNumber = 0 };
            Link link_2 = new() { Id = Guid.NewGuid(), LongURl = "https://metanit.com/sharp/", ShortURL = "metanit.com/sharp", Date = DateTime.Now, VisitsNumber = 0 };

            modelBuilder.Entity<Link>().HasData(new Link[] { link_1, link_2 });

            base.OnModelCreating(modelBuilder);
        }
    }
}