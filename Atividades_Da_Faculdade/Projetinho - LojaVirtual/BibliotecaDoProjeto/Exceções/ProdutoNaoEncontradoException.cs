namespace LojaVirtual.Core.Exceções
{
    /// <summary>
    /// Representa a Înexistência do Produto.
    /// </summary>
    public class ProdutoNaoEncontradoException : Exception
    {
        /// <summary>
        /// Construtor Vazio.
        /// </summary>
        public ProdutoNaoEncontradoException()
        {

        }

        /// <summary>
        /// Construtor com Mensagem Amigável.
        /// </summary>
        /// <param name="mensagem">Mensagem Amigável a ser Exibida ao Cliente.</param>
        public ProdutoNaoEncontradoException(string mensagem) : base(mensagem)
        {

        }

        /// <summary>
        /// Construtor com Mensagem Amigável e ExceçãoInterna.
        /// </summary>
        /// <param name="mensagem">Mensagem Amigável a ser Exibida ao Cliente</param>
        /// <param name="innerException"></param>
        public ProdutoNaoEncontradoException(string mensagem, Exception innerException) : base(mensagem, innerException)
        {

        }
    }
}
