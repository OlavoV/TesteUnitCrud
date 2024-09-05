using CrudTeste.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudTeste.Context
{
    public class BdContext : DbContext
    {
        public BdContext(DbContextOptions<BdContext> options) : base(options)
        {

        }
        public DbSet<Cliente> Clientes { get; set; }
    }

}
