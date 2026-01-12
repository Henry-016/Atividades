using System;

namespace Parte_2___Introducao_a_OO.Parte_2___Introducao_a_OO
{
    public class CalculadoraEstatica
    {
        public static double Somar(double a, double b)
        {
            return a + b;
        }

        public static double Subtrair(double a, double b)
        {
            return a - b;
        }

        public static double Multiplicar(double a, double b)
        {
            return a * b;
        }

        public static double Dividir(double a , double b)
        {
            if (b == 0)
            {
                return -1;
            }

            return a / b;
        }

        public static void Executar()
        {
            double soma = CalculadoraEstatica.Somar(1, 3);
            double sub = CalculadoraEstatica.Subtrair(1, 3);
            double mult = CalculadoraEstatica.Multiplicar(1, 3);
            double div = CalculadoraEstatica.Dividir(1, 3);
            double div2 = CalculadoraEstatica.Dividir(1, 0);

            Console.WriteLine(soma);
            Console.WriteLine(sub);
            Console.WriteLine(mult);
            Console.WriteLine(div);
            Console.WriteLine(div2);
        }
    }
}
