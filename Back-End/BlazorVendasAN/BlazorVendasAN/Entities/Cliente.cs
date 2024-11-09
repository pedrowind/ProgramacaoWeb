using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorVendasAN.Entities
{
    [Table("tbCliente")]
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Nome { get; set; }
        public string CpfCnpj { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }

        public ICollection<Pedido> Pedidos { get; set; }
    }
}
