using System;

namespace AtividadePOO.Excessoes
{
    public class PessoaNaoEncontradaException : Exception
    {
        public PessoaNaoEncontradaException()
        {

        }

        public PessoaNaoEncontradaException(string mensagem) : base(mensagem)
        {

        }
    }
}
