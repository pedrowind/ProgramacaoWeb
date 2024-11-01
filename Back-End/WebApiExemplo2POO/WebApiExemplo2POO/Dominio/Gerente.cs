namespace WebApiExemplo2POO.Dominio
{
    public class Gerente : Empregado
    {
        public Gerente()
        {
        }

        public override void CalcularBonus()
        {
            Bonus = salario * 0.15;
        }
    }
}
