using System;

namespace Parte_4___Exceções.Questões
{
    public class EstoqueException : Exception
    {
        public EstoqueException()
        {

        }

        public EstoqueException(string message) : base(message)
        {

        }
    }

    public class Estoque
    {
        public int quantidadeProduto { get; private set; }

        public Estoque(int quant)
        {
            quantidadeProduto = quant;
        }

        public void AdicionarProduto(int quantidade)
        {
            if (quantidade <= 0)
            {
                throw new EstoqueException("Não faz Sentido! Adicione valores válidos!");
            }

            quantidadeProduto += quantidade;
            Console.WriteLine("Quantidade Adicionada com Sucesso!");
        }
        public void RemoverProduto(int quantidade)
        {
            if (quantidadeProduto < quantidade)
            {
                throw new EstoqueException($"Quantidade Inválida pra Remoção! Há apenas {quantidadeProduto} disponíveis!");
            }

            else if(quantidade <= 0)
            {
                throw new EstoqueException("Não faz Sentido! Adicione valores válidos!");
            }

                quantidadeProduto -= quantidade;
            Console.WriteLine("Quantidade Removida com Sucesso!");
        }
    }
}

/*
  Estoque estoque = new Estoque(200);

            try
            {
                estoque.AdicionarProduto(-249);
            }

            catch(EstoqueException ex)
            {
                Console.WriteLine(ex.Message);
            }
 */
