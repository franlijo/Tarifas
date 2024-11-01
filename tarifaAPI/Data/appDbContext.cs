using Microsoft.EntityFrameworkCore;
using tarifaAPI.Models;

namespace tarifaAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Tarifa> Tarifas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Tarifa>().ToTable("tarifas");

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Empresa>().ToTable("empresas");

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<EmpresaImporte>().ToTable("empresaImportes");

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<EmpresaServicio>().ToTable("empresaServicios");

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<EmpresaTrabajadores>().ToTable("empresaTrabajadores");


        }
    }
}
