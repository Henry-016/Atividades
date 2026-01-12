using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PráticaDoCursoDeC_.Parte_1__PrimeirosPassos
{
    class Questao08
    {
        public static void Executar()
        {
            Console.WriteLine("Digite um número: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($"Resultado de {n} x {i} = {n * i}");
            }
        }
    }
}
