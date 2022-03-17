

namespace Clube_de_leitura
{
    public class Caixa
    {
        public string Cor;
        public string Etiqueta;
        public string Numero;

        public Caixa(string cor, string etiqueta, string numero)
        {
            Cor = cor;
            Etiqueta = etiqueta;
            Numero = numero;
        }

        public override string ToString()
        {
            return $"{Cor}, {Etiqueta}, {Numero}";
        }
    }
}
