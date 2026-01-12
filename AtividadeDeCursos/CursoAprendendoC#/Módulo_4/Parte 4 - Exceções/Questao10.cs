using System;

namespace Parte_4___Exceções.Questões
{
    namespace Parte_4___Exceções.Questões
    {
        public class ProdutoNaoEncontradoException : Exception
        {
            public ProdutoNaoEncontradoException()
            {
            }

            public ProdutoNaoEncontradoException(string message) : base(message)
            {
            }
        }

        public class ErroDeCarrinhoException : Exception
        {
            public ErroDeCarrinhoException()
            {
            }

            public ErroDeCarrinhoException(string message) : base(message)
            {
            }

            public ErroDeCarrinhoException(string message, Exception inner) : base(message, inner)
            {
            }
        }

        public class Carrinho
        {
            private List<(string Nome, double Preco)> produtos = new List<(string, double)>();

            public void AdicionarProduto(string nome, double preco)
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(nome))
                    {
                        throw new ArgumentException("Nome do produto inválido!");
                    }

                    if (preco <= 0)
                    {
                        throw new ArgumentException("Preço inválido!");
                    }

                    produtos.Add((nome, preco));
                    Console.WriteLine($"Produto '{nome}' adicionado com sucesso!");
                }
                catch (Exception ex)
                {
                    throw new ErroDeCarrinhoException("Erro ao adicionar produto no carrinho!", ex);
                }
            }

            public void RemoverProduto(string nome)
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(nome))
                    {
                        throw new ArgumentException("Nome do produto inválido para remoção!");
                    }

                    var produto = produtos.Find(p => p.Nome == nome);

                    if (produto == default)
                    {
                        throw new ProdutoNaoEncontradoException($"Produto '{nome}' não encontrado no carrinho!");
                    }

                    produtos.Remove(produto);
                    Console.WriteLine($"Produto '{nome}' removido com sucesso!");
                }
                catch (ProdutoNaoEncontradoException)
                {
                    // Deixa passar direto porque já é a exceção correta
                    throw;
                }
                catch (Exception ex)
                {
                    throw new ErroDeCarrinhoException("Erro ao remover produto do carrinho!", ex);
                }
            }

            public void ListarProdutos()
            {
                Console.WriteLine("Produtos no Carrinho:");
                foreach (var item in produtos)
                {
                    Console.WriteLine($"- {item.Nome}: R${item.Preco:F2}");
                }
            }
        }
    }

}
