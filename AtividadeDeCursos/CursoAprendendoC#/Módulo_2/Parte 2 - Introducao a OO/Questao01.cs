using System;


namespace Parte_2___Introducao_a_OO.Parte_2___Introducao_a_OO
{
    public class Jogador
    {
        public string nome;
        public double pontuacao;
     
        public static void Executar()
        {
            Jogador jogador1 = new Jogador();
            Jogador jogador2 = new Jogador();

            jogador1.nome = "Enrique";
            jogador1.pontuacao = 27;

            jogador2.nome = "Pedro";
            jogador2.pontuacao = 14;

            if(jogador1.pontuacao > jogador2.pontuacao)
            {
                Console.WriteLine($"{jogador1.nome} Venceu!!!");
            }

            else if(jogador2.pontuacao > jogador1.pontuacao)
            {
                Console.WriteLine($"{jogador2.nome} Venceu!!!");
            }

            else
            {
                Console.WriteLine("Empate!!!");
            }
        }
    }
}
