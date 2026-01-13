namespace LojaVirtual.ConsoleApp.Exceções
{
    /// <summary>
    /// Representa que o Valor informado não é Válido.
    /// </summary>
    public class ValorInvalidoException : Exception
    {
        /// <summary>
        /// Construtor Vazio.
        /// </summary>
        public ValorInvalidoException()
        {

        }

        /// <summary>
        /// Construtor com Mensagem Amigável.
        /// </summary>
        /// <param name="mensagem">Mensagem Amigável a ser Exibida ao Cliente.</param>
        public ValorInvalidoException(string mensagem) : base(mensagem)
        {

        }

        /// <summary>
        /// Construtor com Mensagem Amigável e ExceçãoInterna.
        /// </summary>
        /// <param name="mensagem">Mensagem Amigável a ser Exibida ao Cliente</param>
        /// <param name="innerException"></param>
        public ValorInvalidoException(string mensagem, Exception innerException) : base(mensagem, innerException)
        {

        }
    }
}
