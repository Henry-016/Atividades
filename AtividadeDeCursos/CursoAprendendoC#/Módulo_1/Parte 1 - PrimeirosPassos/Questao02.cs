using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace PráticaDoCursoDeC_.Parte_1__PrimeirosPassos
{
    class Questao02
    {
        public static void Executar()
        {
            Console.WriteLine("Qual foi sua nota na prova? ");
            float nota = float.Parse(Console.ReadLine());

            if(nota >= 90 && nota <= 100)
            {
                Console.WriteLine("Nota: A");
            }

            else if(nota >= 80 && nota <= 89)
            {
                Console.WriteLine("Nota: B");
            }

            else if(nota >= 70 && nota <= 79)
            {
                Console.WriteLine("Nota: C");
            }

            else if(nota >= 60 && nota <= 69)
            {
                Console.WriteLine("Nota: D");
            }

            else if (nota < 60)
            {
                Console.WriteLine("Nota: F");
            }

            else
            {
                Console.WriteLine("Nota Inválida");
            }
        }
    }
}
