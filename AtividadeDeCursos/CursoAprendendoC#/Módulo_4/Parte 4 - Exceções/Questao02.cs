using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_4___Exceções.Questões
{
    public class ValidaIdadeException : Exception
    {
        public ValidaIdadeException()
        {

        }

        public ValidaIdadeException(string mensagem) : base(mensagem)
        {

        }
    }
    public class CadastroDeIdade
    {
        public void Cadastrar(string nome, int idade)
        {
            if (idade < 0)
            {
                throw new ValidaIdadeException("Não é Possível ter Idade Negativa!");
            }

            else if (idade > 130)
            {
                throw new ValidaIdadeException("E tá achando que tu é Moisés? Se saia meu amigo!");
            }

            else
            {
                Console.WriteLine($"O cliente {nome} que possui {idade} anos foi cadastrado com sucesso!");
            }
        }
    }
}


/*
 CadastroDeIdade cad = new CadastroDeIdade();

            while (true)
            {
                Console.WriteLine("Qual o nome do cliente?");
                string nome = Console.ReadLine();
                Console.WriteLine("Qual a idade do cliente?");
                int idade = int.Parse(Console.ReadLine());

                Console.WriteLine("");
                Console.WriteLine("Cadastrando...");
                Console.WriteLine("");

                try
                {
                    cad.Cadastrar(nome, idade);
                    Console.WriteLine("");
                }

                catch (ValidaIdadeException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("");
                }
            }
 */
