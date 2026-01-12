using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PráticaDoCursoDeC_.Parte_1__PrimeirosPassos
{
    class Questao01
    {
        public static void Executar()
        {
            Console.WriteLine("Qual sua data de nascimento? ");
            int dataNascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o ano atual? ");
            int anoAtual = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"Sua idade é: {anoAtual - dataNascimento} anos! ");
        }
    }
}


