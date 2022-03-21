using System;

namespace Clube_de_leitura
{
    public class Reserva
    {
        public Amigo Amigo;
        public Revista Revista;
        public DateTime DataReserva;
        public DateTime DataLimite;

        public Reserva(Amigo amigo, Revista revista)
        {
            Amigo = amigo;
            Revista = revista;
            DataReserva = DateTime.Now;
            DataLimite = DateTime.Now.AddDays(2);
        }

        public override string ToString()
        {
            return $"{Amigo}\n{Revista}\nReserva:{DataReserva} - Limite:{DataLimite}";
        }
    }
}
