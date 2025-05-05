using LocadoraDeCarrosAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LocadoraDeCarrosAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        
        public DbSet<Carro> Carros { get; set; } // Pode ser renomeado para Carros_CP2
        



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Carro>().ToTable("CARROS_CP2");

            // Define a precisão correta sem forçar NUMBER(10,2)
            modelBuilder.Entity<Carro>()
                .Property(c => c.ValorDiaria)
                .HasPrecision(10, 2);
        }

    }
}