using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PráticaDoCursoDeC_.Parte_1__PrimeirosPassos
{
    class Questao14
    {
        public static void Executar()
        {
            //Código Falho, Número 1 passa e pode ser mais eficiente

            int contador = 0;

            Console.WriteLine("Digite o Numero: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                if(n % i == 0)
                {
                    contador++;
                }

                if (contador == 3)
                {
                    Console.WriteLine($"{n} não é PRIMO!!!");
                    break;
                }
            }

            if (contador < 3)
            {
                Console.WriteLine($"{n} é PRIMO!!!");
            }
        }
    }
}
