using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PráticaDoCursoDeC_.Parte_1__PrimeirosPassos
{
    class Questao07
    {
        public static void Executar()
        {
            int tentativas = 0;

            Console.WriteLine("BEM-VINDO AO PC MAIS RÁPIDO DO MUNDO!!!");
            Console.WriteLine();

            while (tentativas < 5)
            {
                Console.WriteLine("Para Logar, Digite o seu Usuario!!! ");
                string usuario = Console.ReadLine().ToUpper();

                Console.WriteLine();

                Console.WriteLine("Agora, Digite sua Senha!!!");
                double senha = double.Parse(Console.ReadLine());
                Console.WriteLine();

                if (usuario == "ADMIN" && senha == 1234)
                {
                    Console.WriteLine("CERTO! Vamos Jogar STARDEW VALLEY PORRA!!!");
                    break;
                }

                else
                {
                    Console.WriteLine("Ihhh, errou algo eim, tente novamente! ");
                    Console.WriteLine();
                    tentativas++;
                }
            }

            if (tentativas == 5)
            {
                Console.WriteLine("Tentativas Excedidas, Tente novamente daq a 2003940934039403 de anos!!!");
            }
        }
    }
}
