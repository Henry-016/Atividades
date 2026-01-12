using System;

namespace Parte_2___Introducao_a_OO.Parte_2___Introducao_a_OO
{
    public class Produto
    {
        public string Nome { get; private set; }
        public double Preco { get; private set; } 

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public void AplicarDesconto(double percentual)
        {
            Preco -= Preco * (percentual / 100);
        }

        public static void Executar()
        {
            Produto produto1 = new Produto("CocaCola", 8);
            Produto produto2 = new Produto("Treloso", 2);

            Console.WriteLine($"Produto1: {produto1.Nome}, Preço: {produto1.Preco} Reais");
            Console.WriteLine($"Produto2: {produto2.Nome}, Preço: {produto2.Preco} Reais");
            Console.WriteLine();

            produto1.AplicarDesconto(50);
            produto2.AplicarDesconto(50);

            Console.WriteLine("Depois dos Descontos:");
            Console.WriteLine($"Produto1: {produto1.Nome}, Preço: {produto1.Preco} Reais");
            Console.WriteLine($"Produto2: {produto2.Nome}, Preço: {produto2.Preco} Reais");
        }
    }
}
