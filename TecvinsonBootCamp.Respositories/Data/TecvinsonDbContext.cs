using Microsoft.EntityFrameworkCore;
using TecvinsonBootCamp.Core.Entities;

namespace TecvinsonBootCamp.Respositories.Data
{
    public class TecvinsonDbContext : DbContext
    {
        public TecvinsonDbContext(DbContextOptions<TecvinsonDbContext> options)
            : base(options)
        {
               
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //one to many relationship
            modelBuilder.Entity<Cohort>()
                 .HasMany(s => s.Mentors)
                 .WithOne(s => s.Cohort)
                 .HasForeignKey(s => s.CohortId);             
        }
        public DbSet<Cohort> Cohorts { get; set; }
        public DbSet<Mentor> Mentors { get; set; }  
    }
}