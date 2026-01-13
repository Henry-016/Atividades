using System;

namespace AtividadePOO.Excessoes
{
    public class PessoaJaExisteException : Exception
    {
        public PessoaJaExisteException()
        {

        }

        public PessoaJaExisteException(string mensagem) : base(mensagem)
        {

        }
    }
}
