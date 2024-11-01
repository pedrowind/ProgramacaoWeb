using Microsoft.AspNetCore.Mvc;

namespace ExemploWebAPIPOO.Controllers
{
    public class PessoaController : ControllerBase
    {
        [HttpPost("InserirPessoa")]
        public string InserirPessoa(string cpfPessoa, string nomePessoa, 
                                    DateTime dataNascimento, string telefone, 
                                    string nomeMaePessoa, string emailPessoa)
        {
            return "Registro inserido com sucesso.";
        }
        [HttpPut("AlterarPessoa")]
        public string AlterarPessoa(string cpfPessoa, string nomePessoa,
                                    DateTime dataNascimento, string telefone,
                                    string nomeMaePessoa, string emailPessoa)
        {
            return "Registro alterado com sucesso.";
        }
        [HttpDelete("ExcluirPessoa")]
        public string ExcluirPessoa(string cpfPessoa, string nomePessoa,
                                    DateTime dataNascimento, string telefone,
                                    string nomeMaePessoa, string emailPessoa)
        {
            return "Registro excluido com sucesso.";
        }
        [HttpGet("PesquisarTodos")]
        public string PesquisarTodos(string cpfPessoa, string nomePessoa,
                                    DateTime dataNascimento, string telefone,
                                    string nomeMaePessoa, string emailPessoa)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.cpf = cpfPessoa;
            pessoa.nome = nomePessoa;
            pessoa.nomeMae = nomeMaePessoa; 
            pessoa.dataNascimento = dataNascimento;
            pessoa.email = emailPessoa;
            pessoa.telefone = telefone;

            return pessoa.PesquisarTodos();
        }
    }
}
