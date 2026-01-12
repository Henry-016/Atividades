using System;

namespace Parte_3___Herança.Questões
{
    public abstract class Animal2
    {
        public string Nome { get; set; }

        public Animal2(string nome)
        {
            Nome = nome;
        }
        public abstract void EmitirSom();
    }

    public interface ICorredor
    {
        void Correr();
    }

    public class Cachorro2 : Animal2, ICorredor
    {
        public Cachorro2(string nome) : base(nome)
        {

        }

        public override void EmitirSom()
        {
            Console.WriteLine("Au Au");
        }

        public void Correr()
        {
            Console.WriteLine("VRUM VRUM VRUM!");
        }
    }

    public class Gato2 : Animal2
    {
        public Gato2(string nome) : base(nome)
        {

        }

        public override void EmitirSom()
        {
            Console.WriteLine("Miau Miau");
        }
    }

    public class Tartaruga2 : Animal2, ICorredor
    {
        public Tartaruga2(string nome) : base(nome)
        {

        }

        public override void EmitirSom()
        {
            Console.WriteLine("Não faço ideia se ela faz som kkkkkk!");
        }

        public void Correr()
        {
            Console.WriteLine("VRUM VRUM VRUM MUITO LENTO!");
        }
    }
}

/* Cachorro2 cachorro = new Cachorro2("Pluto");
            Gato2 gato = new Gato2("Laranja");
            Tartaruga2 tartaruga = new Tartaruga2("Jabuti");

            Console.WriteLine(cachorro.Nome);
            cachorro.EmitirSom();
            cachorro.Correr();
            Console.WriteLine();
            Console.WriteLine(gato.Nome);
            gato.EmitirSom();
            Console.WriteLine();
            Console.WriteLine(tartaruga.Nome);
            tartaruga.EmitirSom();
            tartaruga.Correr();
*/
