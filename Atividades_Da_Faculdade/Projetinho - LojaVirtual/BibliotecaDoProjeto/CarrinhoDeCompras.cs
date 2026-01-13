using System;
using LojaVirtual.Core.Exceções;
using BibliotecaDoProjeto;
using LojaVirtual.ConsoleApp.Exceções;

namespace LojaVirtual.Core
{
    /// <summary>
    /// Representa o Carrinho de Compras do Usuário em sua Totalidade.
    /// </summary>
    public class CarrinhoDeCompras
    {
        /// <summary>
        /// Representa o Carrinho de Compras.
        /// </summary>
        private List<Produto> compras = new List<Produto>();

        /// <summary>
        /// Adiciona um Produto no Carrinho.
        /// </summary>
        /// <param name="nomeDoProduto">Nome do Produto que Deseja Adicionar ao Carrinho</param>
        /// <exception cref="ProdutoNaoEncontradoException"></exception>
        public void AdicionarProduto(string nomeDoProduto)
        {
            if (nomeDoProduto.Length == 0) // Valida se o Nome está Vazio.
            {
                throw new NomeInvalidoException("Nome Inválido! Tente Novamente."); // Lança uma Exceção informando que o Nome é Invalido.
            }

            string nomeDoProdMaisculo = nomeDoProduto.ToUpper(); // Deixa o nome em Maiscúlo.

            foreach (var comp in ControleDeProdutos.EstoqueDaLoja) // Verifica se o Produto que Usúario quer adicionar existe no Estoque da Loja.
            {
                if(comp.Nome == nomeDoProdMaisculo) // Compara os Nomes.
                {
                    if(compras.Contains(comp)) // Valida se o Produto já está no Carrinho.
                    {
                        Console.WriteLine($"{nomeDoProduto} já está Presente em seu Carrinho!");
                        Console.WriteLine("");
                        return;
                    }
                        compras.Add(comp);
                        Console.WriteLine("Produto Adicionado com Sucesso ao seu Carrinho!");
                        Console.WriteLine("");
                        return;
                }
            }
            
            throw new ProdutoNaoEncontradoException($"ERRO! {nomeDoProduto} não existe na loja para ser comprado!"); // Lança uma Exceção para informar que Produto não foi Encontrado na Loja.
        }

        /// <summary>
        /// Remove um Produto do Carrinho.
        /// </summary>
        /// <param name="nomeDoProduto">Nome do Produto que Deseja Remover do Carrinho.</param>
        /// <exception cref="ProdutoNaoEncontradoException"></exception>
        public void RemoverProduto(string nomeDoProduto)
        {
            if (nomeDoProduto.Length == 0) // Valida se o Nome está Vazio.
            {
                throw new NomeInvalidoException("Nome Inválido! Tente Novamente."); // Lança uma Exceção informando que o Nome é Invalido.
            }

            string nomeDoProdMaisculo = nomeDoProduto.ToUpper(); // Deixa o nome em Maiscúlo.

            foreach (var comp in compras) // Verifica se o Produto que o usúario quer Remover Existe no Carrinho.
            {
                if(comp.Nome == nomeDoProdMaisculo)  // Compara os Nomes.
                {
                    compras.Remove(comp);
                    Console.WriteLine("Produto Removido Com Sucesso!");
                    return;
                }
            }

            throw new ProdutoNaoEncontradoException($"ERRO! {nomeDoProduto} não está em seu Carrinho de Compras!"); // Lança uma Exceção para informar que Produto não foi Encontrado no Carrinho.
        }

        /// <summary>
        /// Lista todos os Produtos Presentes na Loja para serem Comprados.
        /// </summary>
        public void CatalogoDaLoja()
        {
            if(ControleDeProdutos.EstoqueDaLoja.Count == 0) // Verifica se há Produto na Loja.
            {
                Console.WriteLine("Não há produtos disponíveis na loja no momento!");
                return;
            }

            Console.WriteLine("Produtos Disponíveis na Loja:");

            foreach (var comp in ControleDeProdutos.EstoqueDaLoja) // Varre a Lista de Produtos da Loja.
            {
                Console.WriteLine("");
                Console.WriteLine($"Nome do Produto: {comp.Nome}");
                Console.WriteLine($"Preço do Produto: R${comp.Preco:F2}");

                if (comp.EstoqueDoProduto <= 0) // Verifica se há Estoque do Produto em questão.
                {
                    Console.WriteLine("Sem Estoque desse Produto no Momento!");
                    Console.WriteLine("");
                }

                else if (comp.EstoqueDoProduto == 1) // Validação de Plural.
                {
                    Console.WriteLine($"Estoque do Produto: Apenas 1 unidade");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine($"Estoque do Produto: {comp.EstoqueDoProduto} unidades"); // Mostra a Quantidade de Produto no Plural.
                    Console.WriteLine("");
                }
                    
            }
        }

        /// <summary>
        /// Lista todos os Produtos Presentes no Carrinho até o Momento.
        /// </summary>
        public void ListarCarrinho()
        {
            if (compras.Count == 0) // Verifica se há Produto no Carrinho.
            {
                Console.WriteLine("Não há produtos disponíveis em seu carrinho até o momento!");
                return;
            }

            Console.WriteLine("Produtos em seu Carrinho:");

            foreach (var comp in compras)
            {
                Console.WriteLine("");
                Console.WriteLine($"Nome do Produto: {comp.Nome}");
                Console.WriteLine($"Preço do Produto: {comp.Preco:F2}");
                Console.WriteLine("");
            }
        }

        /// <summary>
        /// Finaliza a Compra.
        /// </summary>
        /// <exception cref="ValorInvalidoException"></exception>
        /// <exception cref="EstoqueInsuficienteException"></exception>
        public void FinalizarCompra()
        {
            if(compras.Count <= 0)
            {
                Console.WriteLine("Erro! Seu Carrinho está vazio!"); // Verifica se o Carrinho está Vazio.
                return;
            }

            double valorTotal = 0; // Acumula o Valor a Pagar

            foreach(var comp in compras)
            {
                Console.WriteLine($"Quantas Unidades de {comp.Nome} deseja?"); // Pergunta a Quantidade do Produto a ser Comprado.
                int quant = int.Parse(Console.ReadLine());

                if (quant <= 0)
                {
                    throw new ValorInvalidoException($"Não é possível comprar {quant} produtos, tente novamente!"); // Verifica o valor digitado pelo usuário é válido
                }

                if(quant > comp.EstoqueDoProduto)
                {
                    throw new EstoqueInsuficienteException($"No momento não temos essa quantidade disponível em nosso estoque. Peço desculpas! Temos Apenas {comp.EstoqueDoProduto} no momento, pra mais informações, dá uma olhada em nossa Catalógo!");
                }

                valorTotal += comp.Preco * quant;  // Calcula o Preço a Pagar do Produto em Questão.
                comp.EstoqueDoProduto -= quant;  // Atualiza o Estoque do Produto em Questão.
            }

            Console.WriteLine("");
            Console.WriteLine($"Valor Total a Pagar: R${valorTotal:F2}!");
            Console.WriteLine("");

            FormasDePagamento Pagamento = new FormasDePagamento(); // Instancia um Objeto da Classe FormasDePagamento.
            Pagamento.OpçoesDePagamento(valorTotal); // Usa o Objeto pra chamar um Método da Classe FormasDePagamento.
            
            compras.Clear(); // Zera o Carrinho.
        }
    }
}
