using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PráticaDoCursoDeC_.Parte_1__PrimeirosPassos
{
    class Questao09
    {
        public static void Executar()
        {
            int tentativas = 0;

            Random random = new Random();

            int numeroAleatorio = random.Next(1, 10);

            while(true)
            {
                if (tentativas == 5)
                {
                    Console.WriteLine("Você Perdeu!");
                    break;
                }

                Console.WriteLine("Escolha um Número: ");
                int n = int.Parse(Console.ReadLine());

                if (n == numeroAleatorio)
                {
                    Console.WriteLine("Parabéns! Você Venceu!");
                    break;
                }

                else
                {
                    if (n > numeroAleatorio)
                    {
                        Console.WriteLine("MENOS!!!");
                        tentativas++;
                    }

                    else
                    {
                        Console.WriteLine("MAIS");
                        tentativas++;
                    }
                }
            }
        }
    }
}
