using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PráticaDoCursoDeC_.Parte_1__PrimeirosPassos
{
    class Questao05
    {
        public static void Executar()
        {
            int contador = 0;

            Console.WriteLine("Me diz uma frase? ");
            string frase = Console.ReadLine();

            Console.WriteLine("Me diz um número? ");
            int n = int.Parse(Console.ReadLine());

            while(contador < n)
            {
                Console.WriteLine(frase);
                contador++;
            }
        }
    }
}
