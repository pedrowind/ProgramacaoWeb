using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorVendasAN.Entities
{
    [Table("tbFuncionario")]
    public class Funcionario
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Cargo { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Salario { get; set; }
        public DateTime DataAdmissao { get; set; }

        public ICollection<Pedido> Pedidos { get; set; }
    }
}
