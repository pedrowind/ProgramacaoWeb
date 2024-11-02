namespace BlazorVendasAN.Entities
{
    public class ItemVenda
    {
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }

        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }

        public int QuantidadeProduto { get; set; }
        public double PrecoUnitario { get; set; }

        public ICollection<Produto> Produtos { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }
    }
}
