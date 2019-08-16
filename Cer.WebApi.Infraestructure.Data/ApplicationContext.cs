using Cer.WebApi.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Cer.WebApi.Infraestructure.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>()
              .HasKey(t => t.Id);
        }
    }
}
