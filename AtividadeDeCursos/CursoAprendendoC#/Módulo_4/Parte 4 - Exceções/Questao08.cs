using System;

namespace Parte_4___Exceções.Questões
{
    public class CadastroProdutoException : Exception
    {
        public CadastroProdutoException()
        {

        }

        public CadastroProdutoException(string message) : base(message)
        {

        }

        public CadastroProdutoException(string message, Exception ex) : base(message, ex)
        {

        }
    }
    public class ValorInvalido2Exception : Exception
    {
        public ValorInvalido2Exception()
        {

        }

        public ValorInvalido2Exception(string message) : base(message)
        {

        }

        public ValorInvalido2Exception(string message, string nameof, string nameof2) : base(message)
        {

        }
    }

    public class Produto2
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto2(string nome, double preco, int quantidade)
        {
            if (nome == null || nome.Length == 0)
            {
                throw new ArgumentException($"Argumento fornecido inválido: {nameof(nome)}");
            }

            if (preco <= 0 || quantidade <= 0)
            {
                var excecaoInterna = new ValorInvalido2Exception("Foram digitas Valores inválidos! Valor digitado: ", nameof(preco), nameof(quantidade));

                throw new CadastroProdutoException("Erro, tente novamente!", excecaoInterna);
            }

            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
    }
}

/*
 try
            {
                Produto2 teste = new Produto2("", 8, 20);
                Console.WriteLine(teste.Nome);
                Console.WriteLine(teste.Preco);
                Console.WriteLine(teste.Quantidade);
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (CadastroProdutoException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
            }
 */
