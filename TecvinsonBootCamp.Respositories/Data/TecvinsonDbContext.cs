using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using TecvinsonBootCamp.Core.Entities;

namespace TecvinsonBootCamp.Respositories.Data
{
    public class TecvinsonDbContext : DbContext
    {
        public TecvinsonDbContext(DbContextOptions<TecvinsonDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<Cohort> Cohorts { get; set; }
    }
}