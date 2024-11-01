using Microsoft.AspNetCore.Mvc;
using WebApiExemplo2POO.Dominio;

namespace WebApiExemplo2POO.Controllers
{
    public class DiretorController : Controller
    {
        [HttpGet("RetornarDadosDiretor")]
        
        public string RetornarDadosDiretor (string cpfFuncionario, string nomeFuncionario, 
                                            int horasTrabalhadas)
        {
            Diretor diretor = new Diretor();
            diretor.Cpf = cpfFuncionario;
            diretor.Nome = nomeFuncionario;
            diretor.CalcularSalario(horasTrabalhadas);
            diretor.CalcularBonus();
            return diretor.ToString();
        }
    }
}
