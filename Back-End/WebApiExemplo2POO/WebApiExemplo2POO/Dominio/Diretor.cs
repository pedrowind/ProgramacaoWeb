namespace WebApiExemplo2POO.Dominio
{
    public class Diretor : Empregado
    {
        public Diretor()
        {
        }

        public override void CalcularSalario(int horasTrabalhadas)
        {
            Salario = horasTrabalhadas * 200;
        }
    }
}
