using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PráticaDoCursoDeC_.Parte_1__PrimeirosPassos
{
    class Questao15
    {
        public static void Executar()
        {
            double somatorio = 0;

            Console.WriteLine("Digite um Numero Positivo!");
            int n = int.Parse(Console.ReadLine());

            while (true)
            {
                if (n < 0)
                {
                    Console.WriteLine("Numero Inválido, Digite Outro!");
                    break;
                }

                foreach (int num in n.ToString())
                {
                    somatorio += num - '0';
                }

                break;

            }

            Console.WriteLine($"A soma dos dígitos que compoe {n} é {somatorio}!");

        }
    }
}


