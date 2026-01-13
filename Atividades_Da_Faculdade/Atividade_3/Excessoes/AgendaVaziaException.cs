using System;

namespace AtividadePOO.Excessoes
{
    public class AgendaVaziaException : Exception
    {
        public AgendaVaziaException()
        {

        }

        public AgendaVaziaException(string mensagem) : base(mensagem)
        {

        }
    }
}
