using BlazorVendasAN.Data.Context;
using BlazorVendasAN.Entities;
using BlazorVendasAN.Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace BlazorVendasAN.Service.Implementation
{
    public class ProdutoService:IProdutoService
    {
        private readonly SQLServerContext _context;

        public ProdutoService(SQLServerContext context)
        {
            _context = context;
        }

        async Task IProdutoService.AdicionarAsync(Produto produto)
        {
            _context.produtos.Add(produto);
            await _context.SaveChangesAsync();
        }
        async Task IProdutoService.AlterarAsync(Produto produto)
        {
            _context.produtos.Update(produto);
            await _context.SaveChangesAsync();
        }

        async Task IProdutoService.ExcluirAsync(int id)
        {
            var produto = await _context.produtos.FindAsync(id);
            if (produto != null) 
            {
                _context.produtos.Remove(produto);
                await _context.SaveChangesAsync();
            }
        }

        async Task<Produto> IProdutoService.ObterPorIdAsync(int id)
        {
            return await _context.produtos.FindAsync(id);
        }

        async Task<IEnumerable<Produto>> IProdutoService.ObterTodosAsync()
        {
            return await _context.produtos.ToListAsync();
        }
    }
}