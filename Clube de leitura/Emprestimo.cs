using System;

namespace Clube_de_leitura
{
    public class Emprestimo
    {
        public Amigo Amigo;
        public Revista Revista;
        public DateTime DataEmprestimo;
        public DateTime DataDevolucao;

        public Emprestimo(Amigo amigo, Revista revista, DateTime dataemprestimo, DateTime dataDevolucao)
        {
            Amigo = amigo;
            Revista = revista;
            DataEmprestimo = dataemprestimo;
            DataDevolucao = dataDevolucao;
        }

        public override string ToString()
        {
            return $"{Amigo}\n{Revista}\nEmpretimo:{DataEmprestimo} - Devolução:{DataDevolucao}";
        }
    }
}
