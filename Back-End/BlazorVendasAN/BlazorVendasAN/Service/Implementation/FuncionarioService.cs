using BlazorVendasAN.Data.Context;
using BlazorVendasAN.Entities;
using BlazorVendasAN.Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace BlazorVendasAN.Service.Implementation
{
    public class FuncionarioService:IFuncionarioService
    {
        private readonly SQLServerContext _context;

        public FuncionarioService(SQLServerContext context)
        {
            _context = context;
        }

        async Task IFuncionarioService.AdicionarAsync(Funcionario funcionario)
        {
            _context.funcionarios.Add(funcionario);
            await _context.SaveChangesAsync();
        }

        async Task IFuncionarioService.AlterarAsync(Funcionario funcionario)
        {
            _context.funcionarios.Update(funcionario);
            await _context.SaveChangesAsync();
        }

        async Task IFuncionarioService.ExcluirAsync(int id)
        {
            var funcionario = await _context.funcionarios.FindAsync(id);
            if (funcionario != null)
            {
                _context.funcionarios.Remove(funcionario);
                await _context.SaveChangesAsync();
            }
        }

        async Task<Funcionario> IFuncionarioService.ObterPorIdAsync(int id)
        {
            return await _context.funcionarios.FindAsync(id);
        }

        async Task<Funcionario> IFuncionarioService.ObterPorNomeAsync(string nome)
        {
            return await _context.funcionarios.FindAsync(nome);
        }

        async Task<IEnumerable<Funcionario>> IFuncionarioService.ObterTodosAsync()
        {
            return await _context.funcionarios.ToListAsync();
        }
    }
}
