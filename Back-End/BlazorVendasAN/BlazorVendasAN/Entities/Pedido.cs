namespace BlazorVendasAN.Entities
{
    public class Pedido
    {
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
