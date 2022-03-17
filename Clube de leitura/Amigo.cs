

namespace Clube_de_leitura
{
    public class Amigo
    {
        public string Nome;
        public string Responsaveis;
        public string Telefone;
        public string Endereco;

        public Amigo(string nome, string responsaveis, string telefone, string endereco)
        {
            Nome = nome;
            Responsaveis = responsaveis;
            Telefone = telefone;
            Endereco = endereco;
        }

        public override string ToString()
        {
            return $"{Nome}, {Responsaveis}, {Telefone}, {Endereco}";
        }
    }
}
