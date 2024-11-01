namespace ExemploWebAPIPOO
{
    public class Pessoa
    {
        //Atributos
        public string cpf;
        public string nome;
        public DateTime dataNascimento;
        public string nomeMae;
        public string telefone;
        public string email;

        //Metodos
        public void Inserir()
        {
            //Incluir pessoa
        }
        public string PesquisarTodos()
        {
            string retorno = $"CPF: {cpf}\r\n" +
                             $"Nome: {nome}\r\n" +
                             $"Nome da Mãe: {nomeMae}\r\n" +
                             $"Telefone: {telefone}\r\n" +
                             $"Email: {email}\r\n";
            return retorno;
        }
        public string PesquisarPorCpf(string cpf)
        {
            string retorno = $"CPF: {cpf}\r\n" +
                 $"Nome: {nome}\r\n" +
                 $"Nome da Mãe: {nomeMae}\r\n" +
                 $"Telefone: {telefone}\r\n" +
                 $"Email: {email}\r\n";
            return retorno;
        }
        public void Alterar(Int32 id)
        {
            //Incluir pessoa
        }
        public void Excluir(Int32 id)
        {
            //Incluir pessoa
        }
    }
}
