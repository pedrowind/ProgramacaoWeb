namespace WebApiExemplo2POO.Dominio
{
    public class Empregado
    {
        private string cpf;
        private string nome;
        protected double salario;
        protected double bonus;



        public string Cpf { get => cpf; set => cpf = value; }
        public string Nome { get => nome; set => nome = value; }
        protected double Salario { get => salario; set => salario = value; }
        protected double Bonus { get => bonus; set => bonus = value; }

        public virtual void CalcularSalario(int horasTrabalhadas)
        {
            Salario = horasTrabalhadas * 100;
        }
        public virtual void CalcularBonus()
        {
            bonus = salario * 0.1;
        }

        public override string ToString()
        {
            return $"CPF: {cpf}\r\n" +
                    $"Nome: {nome}\r\n" +
                    $"Salário: {salario}\r\n" +
                    $"Bônus: {bonus}";
        }
    }
}
