using System;

namespace AtividadePOO.Excessoes
{
    public class SenhaIncorretaException : Exception
    {
        public SenhaIncorretaException()
        {

        }

        public SenhaIncorretaException(string mensagem) : base(mensagem)
        {

        }
    }
}
        


