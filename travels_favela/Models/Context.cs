using Microsoft.EntityFrameworkCore;

namespace travels_favela.Models
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Promocao> Promocao { get; set; }
    }
}
