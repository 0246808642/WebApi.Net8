using Microsoft.EntityFrameworkCore;
using WebApi.Net8.Models;

namespace WebApi.Net8.Data
{
    public class AppDbContext :  DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :  base(options) 
        {
            
        }

        public DbSet<AutorModel> Autores { get; set; }
        public DbSet<LivroModel> Livros { get; set; }
    }
}
