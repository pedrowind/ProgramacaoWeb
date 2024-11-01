using Microsoft.AspNetCore.Mvc;
using WebApiExemplo2POO.Dominio;

namespace WebApiExemplo2POO.Controllers
{
    public class FuncionarioController : ControllerBase
    {
        [HttpGet("RetornarDadosFuncionario")]

        public string RetornarDadosFuncionario(string nomeFuncionario, string sexoFuncionario, 
                                               int idadeFuncionario, double salarioFuncionario)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = nomeFuncionario;
            funcionario.Idade = idadeFuncionario;
            funcionario.Sexo = sexoFuncionario;
            funcionario.Salario = salarioFuncionario;
            return funcionario.ToString();
        }

        [HttpPost("CalcularDecimoTerceiro")]

        public string CalcularDecimoTerceiro(string nomeFuncionario, string sexoFuncionario,
                                             int idadeFuncionario, double salarioFuncionario,
                                             int meses)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = nomeFuncionario;
            funcionario.Idade = idadeFuncionario;
            funcionario.Sexo = sexoFuncionario;
            funcionario.Salario = salarioFuncionario;

            return $"Nome: {funcionario.Nome}\r\n" +
                   $"Idade {funcionario.Idade}\r\n" +
                   $"Sexo: {funcionario.Sexo}\r\n" +
                   $"Salário: {funcionario.Salario}\r\n" +
                   $"Décimo Terceiro: R${funcionario.CalcularDecimoTerceiro(meses)}";
        }

        [HttpPost("CalcularFerias")]

        public string CalcularFerias(string nomeFuncionario, string sexoFuncionario,
                                     int idadeFuncionario, double salarioFuncionario)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = nomeFuncionario;
            funcionario.Idade = idadeFuncionario;
            funcionario.Sexo = sexoFuncionario;
            funcionario.Salario = salarioFuncionario;
            funcionario.CalcularFerias();

            return $"Nome: {funcionario.Nome}\r\n" +
                   $"Idade {funcionario.Idade}\r\n" +
                   $"Sexo: {funcionario.Sexo}\r\n" +
                   $"Salário + Férias: {Math.Round(funcionario.Salario, 2)}";
        }
    }
}
