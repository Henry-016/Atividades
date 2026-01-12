using System;

namespace Parte_2___Introducao_a_OO.Parte_2___Introducao_a_OO
{
    public class Jogador3
    {
        public string nome;
        private double pontuacao; // Com o Private, não será possível mudar o valor da pontuação diretamente fora da classe, apenas pelo Método MarcarPonto.

        public void MarcarPonto(double valor)
        {
            pontuacao += valor;
        }

        public static void Executar()
        {
            Jogador3 jogador1 = new Jogador3();
            Jogador3 jogador2 = new Jogador3();

            jogador1.nome = "Enrique";
            jogador2.nome = "Pedro";

        }
    }
}
