

using BlazorVendasAN.Entities;

namespace BlazorVendasAN.Service.Interface
{
    public interface IClienteService
    {
        Task<Cliente> ObterPorIdAsync(int id);
        Task<Cliente> ObterPorNomeAsync(string nome);
        Task<IEnumerable<Cliente>> ObterTodosAsync();
        Task AdicionarAsync(Cliente cliente);
        Task AlterarAsync(Cliente cliente);
        Task ExcluirAsync(int id);
    }
}
