using System;

namespace Parte_3___Herança.Questões
{
    public interface ICuravel
    {
        void Curar();
    }
    public abstract class Personagem
    {
        public string Nome { get; set; }
        public int Nivel { get; private set; }

        public Personagem(string nome)
        {
            Nome = nome;
            Nivel = 0;
        }
        public abstract void ExecutarHabilidade();
    }

    public class Mago : Personagem, ICuravel
    {
        public Mago(string nome) : base(nome)
        {

        }

        public override void ExecutarHabilidade()
        {
            Console.WriteLine("Lançando Magia!");
        }

        public void Curar()
        {
            if (Nivel > 5)
            {
                Console.WriteLine("Cura Realizada com Sucesso;");
                return;
            }

            Console.WriteLine("Nível Insuficiente! Não foi Possível Usar a Cura!");
        }
    }
}
