using LojaVirtual.ConsoleApp.Exceções;
using LojaVirtual.Core;
using LojaVirtual.Core.Exceções;

namespace BibliotecaDoProjeto
{
    /// <summary>
    /// Tem como Objetivo Controlar os Produtos da Loja.
    /// </summary>
    public class ControleDeProdutos
    {
        /// <summary>
        /// Representa o Estoque da Loja.
        /// </summary>
        internal static List<Produto> EstoqueDaLoja = new List<Produto>();

        /// <summary>
        /// Cadastra um Produto no Estoque da Loja.
        /// </summary>
        /// <param name="nomeDoProduto">Nome do Produto a ser Cadastrado.</param>
        /// <param name="precoDoProduto">Preço Unitário do Produto a ser Cadastrado.</param>
        /// <param name="quantidade">Quantidade do Produto Disponível para ser Comprado.</param>
        /// <exception cref="ValorInvalidoException"></exception>
        public void CadastrarProduto(string nomeDoProduto,  double precoDoProduto, int quantidade)
        {
            if(quantidade < 0) // Verifica se o valor digitado é válido.
            {
                throw new ValorInvalidoException($"ERRO! {quantidade} não é um valor válido pra Inicializar o Estoque!"); // Lança uma Exceção informando que o valor fornecido pro Estoque é inadequado.
            }

            if(precoDoProduto < 0) // Verifica se o valor digitado é válido.
            {
                throw new ValorInvalidoException($"ERRO! {precoDoProduto} não é um valor válido para Preço!"); // Lança uma Exceção informando que o valor fornecido para o Preço é inadequado.
            }

            if (nomeDoProduto.Length == 0) // Valida se o Nome está Vazio.
            {
                throw new NomeInvalidoException("Nome Inválido! Tente Novamente."); // Lança uma Exceção informando que o Nome é Invalido.
            }


            string nomeDoProdutoMaisculo = nomeDoProduto.ToUpper();

            foreach(var comp in EstoqueDaLoja) // Valida se o Produto já Existe ou não no Estoque
            {
                if(nomeDoProdutoMaisculo == comp.Nome)
                {
                    Console.WriteLine($"{nomeDoProduto} já existe no Estoque!");
                    Console.WriteLine("");
                    return;
                }
            }

            Produto novoProduto = new Produto(nomeDoProduto, precoDoProduto, quantidade); // Instancia um Objeto da Classe Produto com as Informações Passadas.
            EstoqueDaLoja.Add(novoProduto); // Adiciona esse Objeto ao Estoque.
            Console.WriteLine("Produto Cadastrado com Sucesso!");
            Console.WriteLine("");
        }

        /// <summary>
        /// Remove um Produto do Estoque da Loja.
        /// </summary>
        /// <param name="nomeDoProduto">Nome do Produto que Deseja Remover do Estoque.</param>
        /// <exception cref="ProdutoNaoEncontradoException"></exception>
        public void RemoverProduto(string nomeDoProduto)
        {
            if (nomeDoProduto.Length == 0) // Valida se o Nome está Vazio.
            {
                throw new NomeInvalidoException("Nome Inválido! Tente Novamente."); // Lança uma Exceção informando que o Nome é Invalido.
            }

            string nomeDoProdutoMaisculo = nomeDoProduto.ToUpper(); // Deixa o Nome em Maiscúlo.

            foreach(var comp in EstoqueDaLoja) // Verifica se o Produto que o usúario quer Remover Existe no Estoque da Loja. 
            {
                if(comp.Nome ==  nomeDoProdutoMaisculo) // Compara os Nomes.
                {
                    EstoqueDaLoja.Remove(comp);
                    Console.WriteLine("Produto Removido do Estoque da Loja com Sucesso!");
                    Console.WriteLine("");
                    return;
                }
            }

            throw new ProdutoNaoEncontradoException($"{nomeDoProduto} não existe no Estoque da Loja!"); // Lança uma Exceção informando que o Produto não existe no Estoque.
        }

        /// <summary>
        /// Atualiza o Estoque de um Determinado Produto.
        /// </summary>
        /// <param name="nomeDoProduto">Nome do Produto.</param>
        /// <param name="quantidade">Quantidade que será Incrementada ao Estoque do Produto</param>
        /// <exception cref="NomeInvalidoException"></exception>
        /// <exception cref="ValorInvalidoException"></exception>
        /// <exception cref="ProdutoNaoEncontradoException"></exception>
        public void AtualizarEstoque(string nomeDoProduto, int quantidade)
        {
            if(nomeDoProduto.Length == 0) // Valida se o Nome está Vazio.
            {
                throw new NomeInvalidoException("Nome Inválido! Tente Novamente."); // Lança uma Exceção informando que o Nome é Invalido.
            }

            if(quantidade <= 0)
            {
                throw new ValorInvalidoException($"{quantidade} não é um valor válido!"); // Lança uma Exceção informando que o valor Informado é Inválido.
            }

            string nomeDoProdutoMaisculo = nomeDoProduto.ToUpper(); // Deixa em Maiscúlo.

            foreach(var comp in EstoqueDaLoja) // Verifica se o Produto existe antes de Atualizar o Estoque.
            {
                if(comp.Nome == nomeDoProdutoMaisculo) // Valida o Nome.
                {
                    comp.EstoqueDoProduto += quantidade; // Atualiza o Estoque.
                    Console.WriteLine("");
                    Console.WriteLine($"Estoque Atualizado com Sucesso!");
                    Console.WriteLine("");
                    return;
                }
            }

            throw new ProdutoNaoEncontradoException($"{nomeDoProduto} não foi encontrado!"); // Lança uma Exceção informando que o Produto não foi Encontrado.
        }
    }
}
