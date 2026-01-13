using System;
using System.Runtime.InteropServices;

namespace LojaVirtual.Core
{
    /// <summary>
    /// Representa de Forma Fictícia o Pagamento feito pelos Clientes da Loja.
    /// </summary>
    internal class FormasDePagamento
    { 
        /// <summary>
        /// Representa uma Interface pro Usuário escolher o Método de Pagamento Desejado.
        /// </summary>
        public void Interface()
        {
            Console.WriteLine("Formas de Pagamento Disponíveis:");
            Console.WriteLine();
            Console.WriteLine("Digite '1' pra Pix!");
            Console.WriteLine("Digite '2' pra Cartão de Débito!");
            Console.WriteLine("Digite '3' pra Cartão de Crédito!");
            Console.WriteLine("Digite '4' pra Boleto!");
            Console.WriteLine();
        }

        /// <summary>
        /// Representa as Interações Fictícia de Pagamento realizado pelos Clientes da Loja.
        /// </summary>
        /// <param name="valorDasCompras"></param>
        public void OpçoesDePagamento(double valorDasCompras)
        {

            Interface(); // Chama o Método Interface.

            while (true) // Garante que o Pagamento será efetuado.
            {
                Console.WriteLine("Escolha a Forma de Pagamento!");
                int escolha = int.Parse(Console.ReadLine()); // Captura a forma de Pagamento que o Cliente Deseja.

                if (escolha == 1) // PIX.
                {
                    Console.WriteLine($"Você escolheu PIX... Será gerado o QR CODE ou PIX Copia e Cola no valor de R${valorDasCompras}, um momento...");
                    Console.WriteLine("Prontinho! Aguardando pagamento...");
                    Thread.Sleep(3000);
                    Console.WriteLine("Pagamento Aprovado! Obrigado e Volte Sempre!");
                    break;
                }
                
                else if (escolha == 2) // Cartão de Débito.
                {
                    Console.WriteLine("Você escolheu Cartão de Débito, preencha os dados do cartão, aguardando...");
                    Thread.Sleep(2000);
                    Console.WriteLine("Validando Dados...");
                    Thread.Sleep(3000);
                    Console.WriteLine($"Pagamento Aprovado no valor de R${valorDasCompras}! Obrigado e Volte Sempre!");
                    break;
                }

                else if (escolha == 3) // Cartão de Crédito.
                {
                    Console.WriteLine("Você escolheu Cartão de Crédito, preencha os dados do cartão, aguardando...");
                    Thread.Sleep(2000);
                    Console.WriteLine("");
                    Console.WriteLine("Em quantas parcelas será dividido?");
                    int parcelas = int.Parse(Console.ReadLine());
                    double calc = valorDasCompras / parcelas;
                    Console.WriteLine("");
                    Console.WriteLine("Validando Dados...");
                    Thread.Sleep(3000);
                    Console.WriteLine("");
                    Console.WriteLine($"Pagamento Aprovado no valor total de R${valorDasCompras:F2}, em {parcelas} parcelas de R${calc:F2}! Obrigado e Volte Sempre!");
                    break;
                }

                else if (escolha == 4) // Boleto.
                {
                    Console.WriteLine($"Gerando boleto no valor de R${valorDasCompras}...");
                    Thread.Sleep(2000);
                    Console.WriteLine("Boleto gerado! Aguardando pagamento...");
                    Thread.Sleep(3000);
                    Console.WriteLine($"Pagamento Aprovado no valor de {valorDasCompras}! Obrigado e Volte Sempre!");
                    break;
                }

                else
                {
                    Console.WriteLine("Opção Inválida, tente novamente!"); // Garante que não ocorrerá um erro ao informar um valor inválido.
                }
            }
        }
    }
}
