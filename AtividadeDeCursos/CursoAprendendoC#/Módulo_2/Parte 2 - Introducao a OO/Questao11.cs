using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_2___Introducao_a_OO.Parte_2___Introducao_a_OO
{
    public class Carro
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }

        private double VelocidadeAtual;

        public Carro(string modelo, int ano)
        {
            Modelo = modelo;
            Ano = ano;
        }

        public double Acelerar(double velocidade)
        {
            if (velocidade <= 0)
            {
                Console.WriteLine($"Valor Inválido! {velocidade} não é aceito!");
                return -1;
            }
            VelocidadeAtual = velocidade;
            return 1;
        }

        public double Frear(double valor)
        {
            if(valor < 0)
            {
                Console.WriteLine($"Valor Inválido! {valor} não é aceito!");
                return -1;
            }

            VelocidadeAtual -= valor;
            return 1;
        }

        public void MostrarVelocidade()
        {
            Console.WriteLine($"A Velocidade Atual do Fusquinha é {VelocidadeAtual}! km/h");
        }

        public static void Executar()
        {
            Carro fusquinha = new Carro("Fusca", 1979);

            fusquinha.Acelerar(240);
            fusquinha.Acelerar(-21);
            fusquinha.Frear(-3333);
            fusquinha.Frear(140);
            fusquinha.MostrarVelocidade();
        }
    }
}
