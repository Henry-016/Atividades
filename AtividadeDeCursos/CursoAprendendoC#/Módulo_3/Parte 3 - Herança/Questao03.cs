using System;

namespace Parte_3___Herança.Questões
    {
        public abstract class Funcionario
        {
            public string Nome { get; set; }
            public double Salario { get; private set; }

            public Funcionario(string nome, double salario)
            {
                Nome = nome;
                Salario = salario;
            }

            public abstract double CalcularBonus();
        }

        public interface IAvaliavel
        {
            void Avaliar();
        }

        public class Gerente : Funcionario, IAvaliavel
        {
            public Gerente(string nome, double salario) : base(nome, salario)
            {

            }

            public override double CalcularBonus()
            {
                return Salario * 0.2;
            }
            
            public void Avaliar()
            {
                Console.WriteLine("Gerente Avaliado com Sucesso!");
            }
        }
    }
