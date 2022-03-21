using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clube_de_leitura
{
    public class Categoria
    {
       
        public string Nome;
        public double DiasEmprestimo;
        

        public Categoria(string nome, double diasEmprestimo)
        {
            Nome = nome;
            DiasEmprestimo = diasEmprestimo;
            
        }


        public override string ToString()
        {
            return $"{Nome}, {DiasEmprestimo}";
        }
    }
}

