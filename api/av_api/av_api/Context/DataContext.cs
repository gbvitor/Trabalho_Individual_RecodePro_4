using av_api.Models;
using Microsoft.EntityFrameworkCore;

namespace av_api.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<CadastroViagem> CadastroViagem { get; set; }
        public DbSet<Destinos> Destinos { get; set; }
    }
}
