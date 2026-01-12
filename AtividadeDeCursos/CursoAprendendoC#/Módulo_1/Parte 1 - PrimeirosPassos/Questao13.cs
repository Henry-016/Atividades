using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PráticaDoCursoDeC_.Parte_1__PrimeirosPassos
{
    class Questao13
    {
        public static void Executar()
        {
            int tentativas = 0;

            Console.WriteLine("Cadastre sua Senha!:");
            double senha = double.Parse(Console.ReadLine());

            while(true)
            {
                Console.WriteLine("Digite a senha!");
                double tentarSenha = double.Parse(Console.ReadLine());

                if(tentarSenha == senha)
                {
                    Console.WriteLine("Bem-Vindo ao PC SUPREMO da NASA!");
                    break;
                }

                else
                {
                    if (tentativas < 2)
                    {
                        Console.WriteLine("Senha Incorreta! Tente Novamente!");
                    }
                    tentativas++;
                }

                if(tentativas == 3)
                {
                    Console.WriteLine("Errou Muito! Volte daqui a 300394093403049 de anos!");
                    break;
                }
            }
        }
    }
}
