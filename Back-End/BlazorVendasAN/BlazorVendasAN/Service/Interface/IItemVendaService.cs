using BlazorVendasAN.Entities;

namespace BlazorVendasAN.Service.Interface
{
    public interface IItemVendaService
    {
        Task InserirItemAsync(ItemVenda itemVenda);
        Task ExcluirItemAsync(int id);
    }
}
