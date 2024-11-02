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
    }
}
