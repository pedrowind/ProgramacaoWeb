using BlazorVendasAN.Data.Context;
using BlazorVendasAN.Entities;
using BlazorVendasAN.Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace BlazorVendasAN.Service.Implementation
{
    public class ClienteService:IClienteService
    {
        private readonly SQLServerContext _context;

        public ClienteService(SQLServerContext context)
        {
            _context = context;
        }

        async Task IClienteService.AdicionarAsync(Cliente cliente)
        {
            _context.clientes.Add(cliente);
            await _context.SaveChangesAsync();
        }
        async Task IClienteService.AlterarAsync(Cliente cliente)
        {
            _context.clientes.Update(cliente);
            await _context.SaveChangesAsync();
        }

        async Task IClienteService.ExcluirAsync(int id)
        {
            var cliente = await _context.clientes.FindAsync(id);
            if (cliente != null)
            {
                _context.clientes.Remove(cliente);
                await _context.SaveChangesAsync();
            }
        }

        async Task<Cliente> IClienteService.ObterPorIdAsync(int id)
        {
            return await _context.clientes.FindAsync(id);
        }

        async Task<Cliente> IClienteService.ObterPorNomeAsync(string nome)
        {
            return await _context.clientes.FindAsync(nome);
        }

        async Task<IEnumerable<Cliente>> IClienteService.ObterTodosAsync()
        {
            return await _context.clientes.ToListAsync();
        }
    }
}
