using BlazorVendasAN.Data.Context;
using BlazorVendasAN.Entities;
using BlazorVendasAN.Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace BlazorVendasAN.Service.Implementation
{
    public class ItemVendaService:IItemVendaService
    {
        private readonly SQLServerContext _context;

        public ItemVendaService(SQLServerContext context)
        {
            _context = context;
        }

        async Task IItemVendaService.InserirItemAsync(ItemVenda itemVenda)
        {
            _context.itensVenda.Add(itemVenda);
            await _context.SaveChangesAsync();
        }

        async Task IItemVendaService.ExcluirItemAsync(int id)
        {
            var itemVenda = await _context.itensVenda.FindAsync(id);
            if (itemVenda != null) 
            {
                _context.itensVenda.Remove(itemVenda);
                await _context.SaveChangesAsync();
            }
        }
    }
}
