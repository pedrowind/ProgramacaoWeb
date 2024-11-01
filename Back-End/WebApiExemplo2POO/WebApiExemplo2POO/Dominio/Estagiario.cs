namespace WebApiExemplo2POO.Dominio
{
    public class Estagiario : Empregado
    {
        public Estagiario()
        {
        }

        public override void CalcularSalario(int horasTrabalhadas)
        {
            Salario = horasTrabalhadas * 25;
        }
    }
}
