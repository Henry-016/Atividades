using AtividadeDePOO___Padrões_de_Projeto.Interfaces;
using System;

namespace AtividadeDePOO___Padrões_de_Projeto.Classes
{
    public abstract class Carta : ICarta
    {
        public void GerarCarta(string texto, string destinatario)
        {
            Console.WriteLine($"--- Gerando Carta para: {destinatario} ---");
            GerarSaudacao(destinatario);
            Console.WriteLine($"\nConteúdo:\n{texto}\n");
            Console.WriteLine("Atenciosamente,");
            Console.WriteLine("Sistema de Documentos.");
            Console.WriteLine("--- Carta Concluída ---\n");
        }

        protected abstract void GerarSaudacao(string destinatario);
    }

    public class CartaInformal : Carta
    {
        protected override void GerarSaudacao(string destinatario)
        {
            Console.WriteLine($"Saudação: Oi, {destinatario}!");
        }
    }
    public class CartaFormal : Carta
    {
        protected override void GerarSaudacao(string destinatario)
        {
            Console.WriteLine($"Saudação: Prezado {destinatario},");
        }
    }
}