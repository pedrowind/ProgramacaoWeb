using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorVendasAN.Entities
{
    [Table("tbItemVenda")]
    public class ItemVenda
    {
        [Key]
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        [Key]
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }

        public int QuantidadeProduto { get; set; }
        public double PrecoUnitario { get; set; }

        public ICollection<Produto> Produtos { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }
    }
}
