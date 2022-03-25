using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clube_de_leitura
{
    public class Multa
    {
        public int PrecoPorDia;
        public int DiasAtraso;
        public int ValorMulta;

        public Multa(int precoPorDia, int diasAtraso)
        {
            PrecoPorDia = 5;
            DiasAtraso = diasAtraso;
        }

        public override string ToString()
        {
            return $"{DiasAtraso} Dias de atraso\nMulta de R$5 por dia de atraso - Valor da multa R${ValorMulta}";
        }
    }
}
