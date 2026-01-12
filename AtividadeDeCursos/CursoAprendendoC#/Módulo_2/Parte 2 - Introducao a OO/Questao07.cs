using System;

namespace Parte_2___Introducao_a_OO.Parte_2___Introducao_a_OO
{
    public class Aluno
    {
        public string Nome { get; set; }
        public List<double> Notas { get; private set; }

        public Aluno(string nome)
        {
            Nome = nome;
            Notas = new List<double>();
        }

        public void AdicionarNota(params double[] notas)
        {
            foreach(double nota in notas)
            {
                if (nota > 0)
                {
                    Notas.Add(nota);
                }
            }
        }

        public double CalcularMedia()
        {
            int contador = 0;
            double somatorio = 0;

            foreach(double n in Notas)
            {
                contador += 1;
                somatorio += n;
            }

            double media = somatorio / contador;

            return media;
        }

        public static void Executar()
        {
            Aluno aluno1 = new Aluno("Enrique");

            aluno1.AdicionarNota(8.5, 10);

            double resultado = aluno1.CalcularMedia();

            Console.WriteLine($"A Média de {aluno1.Nome} é {resultado}!");
        }

    }
}
