using System;

namespace Parte_3___Herança.Questões
{
    public class Animal
    {
        public string Nome { get; set; }
        protected int Idade { get; set; }

        public Animal(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        public virtual void EmitirSom()
        {
            Console.WriteLine("...");
        }
    }

    public class Cachorro : Animal
    {
        public Cachorro(string nome, int idade) : base(nome, idade)
        {

        }

        public override void EmitirSom()
        {
            Console.WriteLine("Au Au");
        }
    }

    public class Gato : Animal
    {
        public Gato(string nome, int idade) : base(nome, idade)
        {

        }

        public override void EmitirSom()
        {
            Console.WriteLine("Miau");
        }
    }
}

