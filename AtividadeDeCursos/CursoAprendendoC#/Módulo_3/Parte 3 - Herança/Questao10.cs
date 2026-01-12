using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Parte_3___Herança.Questões
{
    public interface IAtaqueEspecial
    {
        void UsarEspecial(Personagem3 alvo);
    }
    public abstract class Personagem3
    {
        public string Nome { get; set; }
        public int Vida { get; set; }
        public int Nivel { get; set; }

        public Personagem3(string nome)
        {
            Nome = nome;
            Vida = 150;
            Nivel = 1;
        }

        public abstract void Atacar(Personagem3 alvo);
    }

    public class Mago3 : Personagem3, IAtaqueEspecial
    {
        public int Mana { get; set; }
        public Mago3(string nome) : base(nome)
        {
            Mana = 100;
        }

        public override void Atacar(Personagem3 alvo)
        {
            if(Mana >= 15)
            {
                alvo.Vida -= 15;
                Mana -= 15;
                return;
            }

            Console.WriteLine("Mana Insuficiente!");
        }

        public void UsarEspecial(Personagem3 alvo)
        {
            if(Mana >= 65)
            {
                Console.WriteLine("Usando Especial! Raio Laser da Morte!");
                alvo.Vida -= 50;
                Mana -= 65;
                return;
            }
            Console.WriteLine("Mana Insuficiente!");
        }
    }

    public class Guerreiro3 : Personagem3, IAtaqueEspecial
    {
        public int Estamina { get; set; }
        public Guerreiro3(string nome) : base(nome)
        {
            Estamina = 120;
        }

        public override void Atacar(Personagem3 alvo)
        {
            if (Estamina >= 15)
            {
                alvo.Vida -= 20;
                Estamina -= 20;
                return;
            }
            Console.WriteLine("Estamina Insuficiente!");
        }

        public void UsarEspecial(Personagem3 alvo)
        {
            if (Estamina >= 50)
            {
                Console.WriteLine("Usando Especial! Tempestade de Lâminas!");
                alvo.Vida -= 35;
                Estamina -= 50;
                return;
            }

            Console.WriteLine("Estamina Insuficiente!");
        }
    }
}


/*
 *  Mago3 mago3 = new Mago3("Kleiton");
            Guerreiro3 guerreiro3 = new Guerreiro3("Enrique");

            Random rnd = new Random();

            while (true)
            {
                mago3.Mana += 15;
                guerreiro3.Estamina += 15;

                int escolha = rnd.Next(1, 5);

                if(escolha == 1)
                {
                    guerreiro3.Atacar(mago3);
                }

                if (escolha == 2)
                {
                    guerreiro3.UsarEspecial(mago3);
                }

                if(escolha == 3)
                {
                    mago3.Atacar(guerreiro3);
                }

                if(escolha == 4)
                {
                    mago3.UsarEspecial(guerreiro3);
                }

                if(mago3.Vida <= 0)
                {
                    Console.WriteLine($"{guerreiro3.Nome} Venceu!");
                    break;
                }

                if(guerreiro3.Vida <= 0)
                {
                    Console.WriteLine($"{mago3.Nome} Venceu!");
                    break;
                }
            }
*/