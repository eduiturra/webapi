using Microsoft.EntityFrameworkCore;
using webapi.core.Models;
using webapi.data.Configurations;

namespace webapi.data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options
        )
            : base(options)
        {

        }
        public DbSet<Archivos> archivos { get; set; }
        public DbSet<ArchivosLog> archivosLog { get; set; }
        public DbSet<ArchivosTipo> archivosTipo { get; set; }
        public DbSet<ArchivoMateriales> archivoMateriales { get; set; }    

        protected override void OnModelCreating(ModelBuilder modelBuilder)        {
            base.OnModelCreating(modelBuilder);
            new ArchivosConfiguration(modelBuilder.Entity<Archivos>());
        }

    }
}