using Microsoft.EntityFrameworkCore;
using Portfolio.DAL.Entities;

namespace Portfolio.DAL.Context
{
    public class MyPortfolioContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=ARPACI; initial Catalog = PortfolioDB; integrated Security:true;");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Feature> Features { get; set; } 
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolios> Portfolioss { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedia { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<About>().ToTable("Abouts");
        //    modelBuilder.Entity<Contact>().ToTable("Contacts");
        //    modelBuilder.Entity<Experience>().ToTable("Experiences");
        //    modelBuilder.Entity<Feature>().ToTable("Features");
        //    modelBuilder.Entity<Message>().ToTable("Messages");
        //    modelBuilder.Entity<Portfolios>().ToTable("Portfolioss");
        //    modelBuilder.Entity<Skills>().ToTable("Skills");
        //    modelBuilder.Entity<SocialMedia>().ToTable("SocialMedia");
        //    modelBuilder.Entity<Testimonial>().ToTable("Testimonails");
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
