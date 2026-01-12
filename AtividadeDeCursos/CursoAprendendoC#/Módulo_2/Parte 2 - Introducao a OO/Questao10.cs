using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Parte_2___Introducao_a_OO.Parte_2___Introducao_a_OO
{
    public class Livraria
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Paginas { get; set; }

        public List<double> Notas { get; private set; }

        public double MediaNoIDEB { get; private set; }

        public Livraria(string titulo, string autor, int paginas)
        {
            Titulo = titulo;
            Autor = autor;
            Paginas = paginas;
            Notas = new List<double>();
        }

        public void Avaliar(double nota)
        {
            if (nota >= 0)
            {
                Notas.Add(nota);
            }
            else
            {
                Console.WriteLine("Nota Inválida!");
            }
        }

        public double CalcularMediaNotas()
        {
            if (Notas.Count == 0)
            {
                return 0;
            }

            int cont = 0;
            double somador = 0;

            foreach (double nota in Notas)
            {
                somador += nota;
                cont++;
            }

            MediaNoIDEB = somador / cont;
            return MediaNoIDEB;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Título: {this.Titulo}");
            Console.WriteLine($"Autor: {this.Autor}");
            Console.WriteLine($"Quantidade de Páginas: {this.Paginas}");
            Console.WriteLine($"Nota no IDEB: {this.MediaNoIDEB}");
            Console.WriteLine("");
        }

        public static void Executar()
        {
            Livraria livro1 = new Livraria("Sinistro", "Enrique", 46);
            Livraria livro2 = new Livraria("Tenebroso", "Kleiton", 59);

            livro1.Avaliar(9);
            livro1.Avaliar(-5);
            livro1.Avaliar(7);
            livro1.Avaliar(8);
            livro2.Avaliar(-2);
            livro2.Avaliar(5);
            livro2.Avaliar(4);
            livro2.Avaliar(8.5);

            livro1.CalcularMediaNotas();
            livro2.CalcularMediaNotas();

            livro1.ExibirInformacoes();
            livro2.ExibirInformacoes();
        }
    }
}
