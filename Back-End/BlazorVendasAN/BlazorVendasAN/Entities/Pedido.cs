using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorVendasAN.Entities
{
    [Table("tbPedido")]
    public class Pedido
    {
        [Key]
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int FuncionarioId { get; set; }
        public Funcionario Funcionario { get; set; }   
        
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public double ValorTotal { get; set; }

        public ICollection<ItemVenda> ItensVenda { get; set; }


    }
}
