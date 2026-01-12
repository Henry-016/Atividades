using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PráticaDoCursoDeC_.Parte_1__PrimeirosPassos
{
    class Questao11
    {
        public static void Executar()
        {
            int contadorA = 0, contadorE = 0, contadorI = 0, contadorO = 0, contadorU = 0;

            Console.WriteLine("Escolha uma palavra:");
            string palavra = Console.ReadLine().ToLower();

            foreach(char c in palavra)
            {
                if(c == 'a')
                {
                    contadorA++;
                }

                else if(c == 'e')
                {
                    contadorE++;
                }

                else if(c == 'i')
                {
                    contadorI++;
                }

                else if(c == 'o')
                {
                    contadorO++;
                }

                else if(c == 'u')
                {
                    contadorU++;
                }
            }

            Console.WriteLine($"Essa palavra tem {contadorA} letras a, {contadorE} letras e, {contadorI} letras i, {contadorO} letras o e {contadorU} letras u!!!");
        }
    }
}
