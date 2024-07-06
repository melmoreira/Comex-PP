using ComexApiT1.Models;
using Microsoft.EntityFrameworkCore;

namespace ComexApiT1.Data
{
    public class ComexApiContext : DbContext
    {
        public ComexApiContext(DbContextOptions<ComexApiContext> options) : base(options)
        {
            
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
    }
}
