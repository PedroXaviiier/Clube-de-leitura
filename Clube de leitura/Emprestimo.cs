﻿using System;

namespace Clube_de_leitura
{
    public class Emprestimo
    {
        public Amigo Amigo;
        public Revista Revista;
        public DateTime DataEmprestimo;
        public DateTime DataDevolucao;

        public Emprestimo(Amigo amigo, Revista revista, DateTime dataDevolucao)
        {
            Amigo = amigo;
            Revista = revista;
            DataEmprestimo = DateTime.Now;
            DataDevolucao = dataDevolucao ;
        }

        public override string ToString()
        {
            return $"{Amigo}\n{Revista}\nEmprestimo:{DataEmprestimo} - Devolução:{DataDevolucao}";
        }
    }
}
