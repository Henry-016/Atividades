using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PráticaDoCursoDeC_.Parte_1__PrimeirosPassos
{
    class Questao12
    {
        public static void Executar()
        {
            Console.WriteLine("Informe 1 numero: ");
            int n = int.Parse(Console.ReadLine());

            int maior = n;
            int menor = n;
            double somatorio = n;

            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Informe +1 numero: ");
                n = int.Parse(Console.ReadLine());

                somatorio += n;

                if (n > maior)
                {
                    maior = n;
                }

                if (n < menor)
                {
                    menor = n;
                }
            }

            double media = somatorio / 5;

            Console.WriteLine($"A Média eh: {media:F2}");
            Console.WriteLine($"O Maior Numero eh: {maior}");
            Console.WriteLine($"O Menor Numero eh: {menor}");

        }
    }
}
