using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PráticaDoCursoDeC_.Primeiros_Passos___Parte_1
{
    class Questao04
    {
        public static void Executar()
        {
            Console.WriteLine("Digite um número: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("Esse número é par!");
            }

            else
            {
                Console.WriteLine("Esse número é ímpar");
            }
        }
    }
}
