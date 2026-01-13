namespace LojaVirtual.Core.Exceções
{
    /// <summary>
    /// Representa a Ausência de Produto no Estoque.
    /// </summary>
    public class EstoqueInsuficienteException : Exception
    {
        /// <summary>
        /// Construtor Vazio.
        /// </summary>
        public EstoqueInsuficienteException()
        {

        }

        /// <summary>
        /// Construtor com Mensagem Amigável.
        /// </summary>
        /// <param name="mensagem">Mensagem Amigável a ser Exibida ao Cliente.</param>
        public EstoqueInsuficienteException(string mensagem) : base(mensagem)
        {

        }

        /// <summary>
        /// Construtor com Mensagem Amigável e ExceçãoInterna.
        /// </summary>
        /// <param name="mensagem">Mensagem Amigável a ser Exibida ao Cliente</param>
        /// <param name="innerException"></param>
        public EstoqueInsuficienteException(string mensagem, Exception innerException) : base(mensagem, innerException)
        {

        }
    }
}
