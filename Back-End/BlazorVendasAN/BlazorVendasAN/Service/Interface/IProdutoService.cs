using BlazorVendasAN.Entities;

namespace BlazorVendasAN.Service.Interface
{
    public interface IProdutoService
    {
        Task<Produto> ObterPorIdAsync(int id);
        Task<IEnumerable<Produto>> ObterTodosAsync();
        Task AdicionarAsync(Produto produto);
        Task AlterarAsync(Produto produto);
        Task ExcluirAsync(int id);
    }
}
