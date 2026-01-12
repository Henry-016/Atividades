using System;

namespace Parte_3___Herança.Questões
{
    public class Veiculo2
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        protected int VelocidadeAtual { get; set; }

        public Veiculo2(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
            VelocidadeAtual = 0;
        }

        protected virtual void Acelerar(int valor)
        {
            return;
        }
    }

    public interface IAvancar
    {
        void Mover(int valor)
        {

        }
    }

    public class Moto2 : Veiculo2, IAvancar
    {
        public Moto2(string marca, string modelo) : base(marca, modelo)
        {

        }

        protected override void Acelerar(int valor)
        {
            VelocidadeAtual += valor;
        }

        public void Mover(int valor)
        {
            Acelerar(valor);
        }
    }

    public class Carro2 : Veiculo2, IAvancar
    {
        public Carro2(string marca, string modelo) : base(marca, modelo)
        {

        }

        protected override void Acelerar(int valor)
        {
            VelocidadeAtual += valor;
        }

        public void Mover(int valor)
        {
            Acelerar(valor);
        }
    }

    public class Bicicleta2 : Veiculo2, IAvancar
    {
        public Bicicleta2(string marca, string modelo) : base(marca, modelo)
        {

        }

        protected override void Acelerar(int valor)
        {
            VelocidadeAtual += valor;
        }

        public void Mover(int valor)
        {
            Acelerar(valor);
        }
    }
}


/*List<IAvancar> avancar = new List<IAvancar>
            {
                new Carro2("A", "B"),
                new Bicicleta2("C", "D"),
                new Moto2("E", "F")
            };

            foreach(IAvancar v in avancar)
            {
                v.Mover(50);
            }
*/