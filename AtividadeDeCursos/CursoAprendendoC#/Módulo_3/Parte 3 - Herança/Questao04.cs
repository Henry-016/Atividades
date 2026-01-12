using System;

namespace Parte_3___Herança.Questões
{
    public class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        protected int VelocidadeAtual { get; set; }

        public Veiculo(string marca, string modelo, int velocidade)
        {
            Marca = marca;
            Modelo = modelo;
            VelocidadeAtual = velocidade;
        }
        public virtual void Acelerar()
        {
            VelocidadeAtual += 10;
        }

        public void MostrarStatus()
        {
            Console.WriteLine(Marca);
            Console.WriteLine(Modelo);
            Console.WriteLine(VelocidadeAtual);
        }
    }

    public class Moto : Veiculo
    {
        public Moto(string marca, string modelo, int velocidade) : base(marca, modelo, velocidade)
        {

        }

        public override void Acelerar()
        {
            VelocidadeAtual += 30;
        }
    }
}
