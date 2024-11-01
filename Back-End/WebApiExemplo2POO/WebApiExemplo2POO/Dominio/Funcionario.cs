using System.Transactions;

namespace WebApiExemplo2POO.Dominio
{
    public class Funcionario
    {
        private string nome;
        private string sexo;
        private int idade;
        private double salario;


        public string Nome { get => nome; set => nome = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public int Idade { get => idade; set => idade = value; }
        public double Salario { get => salario; set => salario = value; }

        public double CalcularDecimoTerceiro (int mesesTrabalhados)
        {
            double decimoTerceiro = salario * mesesTrabalhados / 12;
            return decimoTerceiro;
        }
        public void CalcularFerias ()
        {
            salario = salario + salario / 3;
        }

        public override string ToString()
        {
            string resultado;
            resultado = $"Nome: {nome}\r\n" +
                        $"Sexo: {sexo}\r\n" +
                        $"Idade: {idade}\r\n" +
                        $"Salário: {salario}";

            return resultado;
        }
    }
}
