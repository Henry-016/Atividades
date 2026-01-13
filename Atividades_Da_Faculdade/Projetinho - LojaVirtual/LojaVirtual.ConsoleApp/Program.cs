using System;
using LojaVirtual.Core;
using BibliotecaDoProjeto;
using LojaVirtual.Core.Exceções;
using LojaVirtual.ConsoleApp.Exceções;

public class Program
{
    public static void Main(string[] args)
    {
        ControleDeProdutos Teste = new();
        CarrinhoDeCompras carrinho = new();

        try
        {
            Teste.CadastrarProduto("CocaCola", 7, 28);
            Teste.CadastrarProduto("Chips", 2.50, 12);
            Teste.CadastrarProduto("Chocolate", 3, 9);
            carrinho.AdicionarProduto("cocacola");
            carrinho.AdicionarProduto("chips");
            carrinho.AdicionarProduto("chocolate");
            carrinho.CatalogoDaLoja();
            carrinho.ListarCarrinho();
            carrinho.FinalizarCompra();
            Teste.AtualizarEstoque("chocolate", 20);
            carrinho.CatalogoDaLoja();
            carrinho.ListarCarrinho();
        }
        catch(ProdutoNaoEncontradoException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(ValorInvalidoException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(EstoqueInsuficienteException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(NomeInvalidoException ex)
        {
            Console.WriteLine(ex.Message);
        }
        
    }
}