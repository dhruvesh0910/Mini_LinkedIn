using Microsoft.EntityFrameworkCore;
using mini_linkedIn.Models;

namespace mini_linkedIn.Data
{
    public class LinkedInContext : DbContext
    {
        public LinkedInContext(DbContextOptions<LinkedInContext> options) : base(options)
        {
        }

        public DbSet<Achievement> Achievements { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Reference> References { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Achievement>().ToTable("Achievement");
            modelBuilder.Entity<Education>().ToTable("Education");
            modelBuilder.Entity<Interest>().ToTable("Interest");
            modelBuilder.Entity<Project>().ToTable("Project");
            modelBuilder.Entity<Reference>().ToTable("Reference");
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<WorkExperience>().ToTable("WorkExperience");
        }

    }
}
