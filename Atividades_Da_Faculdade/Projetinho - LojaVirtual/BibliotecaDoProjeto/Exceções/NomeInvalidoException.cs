using System;

namespace LojaVirtual.Core.Exceções
{
    /// <summary>
    /// Representa que foi informado um Nome Invalido.
    /// </summary>
    public class NomeInvalidoException : Exception
    {
        /// <summary>
        /// Construtor Vazio.
        /// </summary>
        public NomeInvalidoException()
        {

        }

        /// <summary>
        /// Construtor com Mensagem Amigável.
        /// </summary>
        /// <param name="mensagem">Mensagem Amigável a ser Exibida ao Cliente.</param>
        public NomeInvalidoException(string mensagem) : base(mensagem)
        {

        }

        /// <summary>
        /// Construtor com Mensagem Amigável e ExceçãoInterna.
        /// </summary>
        /// <param name="mensagem">Mensagem Amigável a ser Exibida ao Cliente</param>
        /// <param name="innerException"></param>
        public NomeInvalidoException(string mensagem, Exception innerException) : base(mensagem, innerException)
        {

        }
    }
}
