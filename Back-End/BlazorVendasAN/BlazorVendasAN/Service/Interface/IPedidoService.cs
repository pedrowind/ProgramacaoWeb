using BlazorVendasAN.Entities;

namespace BlazorVendasAN.Service.Interface
{
    public interface IPedidoService
    {
        Task RegistrarVendaAsync(Pedido pedido);
        Task<IEnumerable<Pedido>> ListarVendaAsync();
    }
}
