using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PráticaDoCursoDeC_.Parte_1__PrimeirosPassos
{
    class Questao06
    {
        public static void Executar()
        {
            int contador = 0;
            float somatorio = 0;

            while(contador < 5)
            {
                Console.WriteLine("Qual a nota? ");
                float n = float.Parse(Console.ReadLine());

                somatorio += n;

                contador++;
            }

            float calc = somatorio / contador;

            Console.WriteLine($"A média é: {calc:F1}");
        }
    }
}
