

namespace Clube_de_leitura
{
    public class Revista
    {
        public bool JaFoiEmprestada;
        public string Nome;
        public string TipoDeColecao;
        public string Edicao;
        public string Ano;
        public Caixa Caixa;

        public Revista(string nome, string tipoDeColecao, string edicao, string ano, Caixa caixa)
        {
            JaFoiEmprestada = false;
            Nome = nome;
            TipoDeColecao = tipoDeColecao;
            Edicao = edicao;
            Ano = ano;
            Caixa = caixa;
        }

        public override string ToString()
        {
            return $"{Nome}, {TipoDeColecao}, {Edicao}, {Ano}, {Caixa}";
        }
    }
}
