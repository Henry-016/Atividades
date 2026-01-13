using System;

namespace LojaVirtual.Core
{
    /// <summary>
    /// Representa um Produto da Loja.
    /// </summary>
    internal class Produto
    {
        /// <summary>
        /// Nome do Produto.
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Preço Unitário do Produto.
        /// </summary>
        public double Preco { get; set; }

        /// <summary>
        /// Quantidade Disponível do Produto.
        /// </summary>
        public int EstoqueDoProduto { get; set; }

        /// <summary>
        /// Cria um Produto.
        /// </summary>
        /// <param name="nomeDoProduto">Nome do Produto.</param>
        /// <param name="preco">Preço Unitário do Produto.</param>
        /// <param name="estoque">Quantidade Disponível do Produto.</param>
        public Produto(string nomeDoProduto, double preco, int estoque)
        {
            Nome = nomeDoProduto.ToUpper();
            Preco = preco;
            EstoqueDoProduto = estoque;
        }       
    }
}
