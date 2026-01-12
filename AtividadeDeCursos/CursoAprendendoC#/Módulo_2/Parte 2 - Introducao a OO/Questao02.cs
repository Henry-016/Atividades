using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_2___Introducao_a_OO.Parte_2___Introducao_a_OO
{
    public class Jogador2
    {
        public string nome;
        public double pontuacao;

        public void MarcarPonto(double valor)
        {
            pontuacao += valor;
        }
        public static void Executar()
        {
            Jogador2 jogador1 = new Jogador2();
            Jogador2 jogador2 = new Jogador2();

            jogador1.nome = "Enrique";
            jogador1.pontuacao = 0;

            jogador2.nome = "Pedro";
            jogador2.pontuacao = 0;

            int contador = 0;
            
            while (true)
            {
                if (contador == 5)
                {
                    break;
                }

                Random random = new Random();
                int numero = random.Next(1, 3);

                if (numero == 1)
                {
                    Console.WriteLine($"1 ponto pro {jogador1.nome}");
                    jogador1.MarcarPonto(1);
                    contador++;
                }

                else
                {
                    Console.WriteLine($"1 ponto pro {jogador2.nome}");
                    jogador2.MarcarPonto(1);
                    contador++;
                }
            }

            if (jogador1.pontuacao > jogador2.pontuacao)
            {
                Console.WriteLine($"{jogador1.nome} Venceu!!!");
            }

            else
            {
                Console.WriteLine($"{jogador2.nome} Venceu!!!");
            }
        }
    }
}
