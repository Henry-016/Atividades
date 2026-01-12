using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_4___Exceções.Questões
{
    public class OperacaoInvalidaException : Exception
    {
        public OperacaoInvalidaException()
        {

        }

        public OperacaoInvalidaException(string mensagem) : base(mensagem)
        {

        }

        public OperacaoInvalidaException(string mensagem, Exception ex) : base(mensagem, ex)
        {

        }
    }

    public class CalculadoraComExcecao
    {
        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Dividir(int num1, int num2)
        {
            if (num2 == 0)
            {
                throw new OperacaoInvalidaException("Tentativa de Divisão por Zero! Isso não é possível, tente novamente!");
            }

            return num1 / num2;
        }
    }
}


/*
 CalculadoraComExcecao calc = new CalculadoraComExcecao();

            while(true)
            {
                int escolha = int.Parse(Console.ReadLine());
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                if (escolha == 1)
                {
                    Console.WriteLine($"A soma de {num1} e {num2} é {calc.Somar(num1, num2)}!");
                }

                else if(escolha == 2)
                {
                    Console.WriteLine($"A Subtração de {num1} por {num2} é {calc.Subtrair(num1, num2)}!");
                }

                else if(escolha == 3)
                {
                    Console.WriteLine($"A Multiplicação de {num1} por {num2} é {calc.Multiplicar(num1, num2)}!");
                }

                else if(escolha == 4)
                {
                    try
                    {
                        Console.WriteLine($"A Divisão de {num1} por {num2} é {calc.Dividir(num1, num2):F2}!");
                    }

                    catch (OperacaoInvalidaException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                else
                {
                    Console.WriteLine("Opção Inválida, tente novamente!");
                }
            }
 */
