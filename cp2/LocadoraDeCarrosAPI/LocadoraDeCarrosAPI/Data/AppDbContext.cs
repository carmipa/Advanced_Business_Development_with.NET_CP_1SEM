using LocadoraDeCarrosAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LocadoraDeCarrosAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
        public DbSet<Carro> Carros { get; set; }
    }
}
