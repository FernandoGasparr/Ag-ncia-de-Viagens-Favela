using Microsoft.EntityFrameworkCore;

namespace Favela.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<FCliente> FCliente { get; set; }

        public DbSet<FPromocao> FPromocao { get; set; }

    }
}
