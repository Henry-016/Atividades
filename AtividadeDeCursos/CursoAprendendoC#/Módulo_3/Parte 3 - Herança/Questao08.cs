using System;

namespace Parte_3___Herança.Questões
{
    public abstract class Personagem2
    {
        public string Nome { get; set; }

        public int Vida { get; set; }

        public Personagem2(string nome)
        {
            Nome = nome;
            Vida = 100;
        }

        public abstract void Agir();
    }

    public interface IAtacante2
    {
        void Atacar(Personagem2 alvo);
    }

    public class Guerreiro2 : Personagem2, IAtacante2
    {
        public Guerreiro2(string nome) : base(nome)
        {

        }

        public override void Agir()
        {
            Console.WriteLine("Não entendi, qual a funçaõ desse método?");
        }

        public void Atacar(Personagem2 alvo)
        {
            alvo.Vida -= 10;
        }
    }

    public class Arqueiro2 : Personagem2, IAtacante2
    {
        public Arqueiro2(string nome) : base(nome)
        {

        }

        public override void Agir()
        {
            Console.WriteLine("Não entendi, qual a funçaõ desse método?");
        }

        public void Atacar(Personagem2 alvo)
        {
            alvo.Vida -= 10;
        }
    }
}


/*          Guerreiro2 g1 = new Guerreiro2("Enrique");
            Arqueiro2 a1 = new Arqueiro2("Pedro");

            Random random = new Random();

            while (true)
            {
                int escolha = random.Next(1, 3);

                if (escolha == 1)
                {
                    g1.Atacar(a1);
                }

                else
                {
                    a1.Atacar(g1);
                }

                if(g1.Vida <= 0)
                {
                    Console.WriteLine($"Personagem {g1.Nome} foi derrotado!");
                    break;
                }

                if(a1.Vida <= 0)
                {
                    Console.WriteLine($"Personagem {a1.Nome} foi derrotado!");
                    break;
                }
            }
        }
*/