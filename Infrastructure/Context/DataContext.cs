using System.Data.Entity;
using TesteASPNET.Domain.Entities;

namespace TesteASPNET.Infrastructure.Context
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection") { }

        public DbSet<Produto> Produtos { get; set; }
    }
}
