using Microsoft.AspNetCore.Mvc;
using WebApiExemplo2POO.Dominio;

namespace WebApiExemplo2POO.Controllers
{
    public class GerenteController : Controller
    {
        [HttpGet("RetornarDadosGerente")]

        public string RetornarDadosGerente(string cpfFuncionario, string nomeFuncionario,
                                            int horasTrabalhadas)
        {
            Gerente gerente = new Gerente();
            gerente.Cpf = cpfFuncionario;
            gerente.Nome = nomeFuncionario;
            gerente.CalcularSalario(horasTrabalhadas);
            gerente.CalcularBonus();
            return gerente.ToString();
        }
    }
}
