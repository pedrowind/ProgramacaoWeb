using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorVendasAN.Entities
{
    [Table("tbItemVenda")]
    public class ItemVenda
    {
        [Key]
        public int ProdutoId { get; set; }
        [Key]
        public Produto Produto { get; set; }
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }

        public int QuantidadeProduto { get; set; }

        public double PrecoUnitario {  get; set; }
    }
}
