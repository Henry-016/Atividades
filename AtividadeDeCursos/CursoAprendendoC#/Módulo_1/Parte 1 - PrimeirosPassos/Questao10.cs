using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PráticaDoCursoDeC_.Parte_1__PrimeirosPassos
{
    class Questao10
    {
        public static void Executar()
        {
            double somatorio = 0;

            while (true)
            {
                Console.WriteLine("Digite um numero: (ZERO para Parar)");
                int n = int.Parse(Console.ReadLine());

                if(n == 0)
                {
                    break;
                }

                somatorio += n;
            }

            Console.WriteLine($"O Resultado da somas de todos os numeros digitado é: {somatorio}");
        }
    }
}
