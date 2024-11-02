using BlazorVendasAN.Data.Context;
using BlazorVendasAN.Entities;
using BlazorVendasAN.Service.Interface;

namespace BlazorVendasAN.Service.Implementation
{
    public class FuncionarioService:IFuncionarioService
    {
        private readonly SQLServerContext _context;

        public FuncionarioService(SQLServerContext context)
        {
            _context = context;
        }

        Task IFuncionarioService.AdicionarAsync(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }

        Task IFuncionarioService.AlterarAsync(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }

        Task IFuncionarioService.ExcluirAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<Funcionario> IFuncionarioService.ObterPorIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<Funcionario> IFuncionarioService.ObterPorNomeAsync(string nome)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Funcionario>> IFuncionarioService.ObterTodosAsync()
        {
            throw new NotImplementedException();
        }
    }
}
