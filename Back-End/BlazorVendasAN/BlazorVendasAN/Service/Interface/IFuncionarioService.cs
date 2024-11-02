using BlazorVendasAN.Entities;

namespace BlazorVendasAN.Service.Interface
{
    public interface IFuncionarioService
    {
        Task <Funcionario> ObterPorNomeAsync(string nome);
        Task<Funcionario> ObterPorIdAsync(int id);
        Task <IEnumerable<Funcionario>> ObterTodosAsync();
        Task AdicionarAsync(Funcionario funcionario);
        Task AlterarAsync(Funcionario funcionario);
        Task ExcluirAsync(int id);
    }
}
