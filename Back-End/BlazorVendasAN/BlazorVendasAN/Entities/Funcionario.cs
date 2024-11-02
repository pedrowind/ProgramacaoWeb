namespace BlazorVendasAN.Entities
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataAdmissao { get; set; }

        public ICollection<Pedido> Pedidos { get; set; }
    }
}
