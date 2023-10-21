using Microsoft.EntityFrameworkCore;

namespace CineviewsApp.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public  DbSet<Filme> Filmes { get; set; }

        public DbSet<Meufilme> Meufilmes { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

    }
}
