

namespace Clube_de_leitura
{
    public class Revista
    {
        public bool JaFoiEmprestada;
        public bool JaFoiReservada;
        public string Nome;
        public string TipoDeColecao;
        public string Edicao;
        public string Ano;
        public Categoria Categoria;
        public Caixa Caixa;

        public Revista(string nome, string tipoDeColecao, string edicao, string ano, Categoria categoria, Caixa caixa)
        {
            JaFoiReservada = false;
            JaFoiEmprestada = false;
            Nome = nome;
            TipoDeColecao = tipoDeColecao;
            Edicao = edicao;
            Ano = ano;
            Categoria = categoria;
            Caixa = caixa;
        }

        public override string ToString()
        {
            return $"{Nome}, {TipoDeColecao}, {Edicao}, {Ano}, {Categoria}, {Caixa}";
        }
    }
}
