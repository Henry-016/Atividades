using System;

namespace Parte_3___Herança.Questões
{
    public interface IAtacante
    {
        void Atacar();
    }

    public interface IDefensor
    {
        void Defender();
    }

    public class Guerreiro : IAtacante, IDefensor
    {
        public void Status()
        {
            Console.WriteLine("Pronto para a Batalha!");
        }

        public void Atacar()
        {
            Console.WriteLine("ATACAR!!!");
        }
        public void Defender()
        {
            Console.WriteLine("DEFENDER!!!");
        }
    }
}
