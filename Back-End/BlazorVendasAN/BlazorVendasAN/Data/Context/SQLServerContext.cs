using BlazorVendasAN.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorVendasAN.Data.Context
{
    public class SQLServerContext : DbContext
    {
        public SQLServerContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Funcionario> funcionarios { get; set; }
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Produto> produtos { get; set; }
        public DbSet<ItemVenda> itensVenda { get; set; }
        public DbSet<Pedido> pedidos { get; set; }
    }
}
