using Microsoft.AspNetCore.Mvc;
using WebApiExemplo2POO.Dominio;

namespace WebApiExemplo2POO.Controllers
{
    public class EstagiarioController : Controller
    {
        [HttpGet("RetornarDadosEstagiario")]

        public string RetornarDadosEstagiario(string cpfFuncionario, string nomeFuncionario,
                                            int horasTrabalhadas)
        {
            Estagiario estagiario = new Estagiario();
            estagiario.Cpf = cpfFuncionario;
            estagiario.Nome = nomeFuncionario;
            estagiario.CalcularSalario(horasTrabalhadas);
            estagiario.CalcularBonus();
            return estagiario.ToString();
        }
    }
}
