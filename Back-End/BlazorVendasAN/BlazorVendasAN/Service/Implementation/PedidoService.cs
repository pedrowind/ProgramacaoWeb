using BlazorVendasAN.Data.Context;
using BlazorVendasAN.Entities;
using BlazorVendasAN.Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace BlazorVendasAN.Service.Implementation
{
    public class PedidoService:IPedidoService
    {
        private readonly SQLServerContext _context;

        public PedidoService(SQLServerContext context)
        {
            _context = context;
        }

        async Task IPedidoService.RegistrarVendaAsync(Pedido pedido)
        {
            _context.pedidos.Add(pedido);
            await _context.SaveChangesAsync();
        }

        async Task<IEnumerable<Pedido>> IPedidoService.ListarVendaAsync()
        {
            return await _context.pedidos.ToListAsync();
        }
    }
}
