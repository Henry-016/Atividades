using System;

namespace Parte_3___Herança.Questões
{
        public interface IVoar
        {
            void Voar();
        }

        public interface INadar
        {
            void Nadar();
        }

    public class Pato : IVoar, INadar
    {
        public void Voar()
        {
            Console.WriteLine("Voando como um Pato!");
        }

        public void Nadar()
        {
            Console.WriteLine("Nadando como um Pato!");
        }
    }

    public class Avestruz : INadar
    {
        public void Nadar()
        {
            Console.WriteLine("Nadando como um Avestruz!");
        }
    }

    public class Aguia : IVoar
    {
        public void Voar()
        {
            Console.WriteLine("Voando como uma Aguia!");
        }
    }
}


/*  public static void Main(string[] args)
        {
            List<Pato> patos = new List<Pato>
            {
                new Pato(),
                new Pato(),
                new Pato()
            };

            List<Avestruz> avestruzes = new List<Avestruz>
            {
                new Avestruz(),
                new Avestruz(),
                new Avestruz()
            };

            List<Aguia> aguias = new List<Aguia>
            {
                new Aguia(),
                new Aguia(),
                new Aguia()
            };

            foreach (Pato pato in patos)
            {
                pato.Voar();
                pato.Nadar();
                Console.WriteLine("");
            }

            foreach (Avestruz avestruz in avestruzes)
            {
                avestruz.Nadar();
                Console.WriteLine("");
            }

            foreach (Aguia aguia in aguias)
            {
                aguia.Voar();
                Console.WriteLine("");
            }
        }
 */