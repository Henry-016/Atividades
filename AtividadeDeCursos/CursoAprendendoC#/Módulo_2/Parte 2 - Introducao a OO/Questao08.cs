using System;

namespace Parte_2___Introducao_a_OO.Parte_2___Introducao_a_OO
{
    public static class Temperatura
    {
        public static double ConverterParaCelsius(double fahrenheit)
        {
            double calc = (fahrenheit - 32) / 1.8;
            return calc;
        }
        public static double ConverterParaFahrenheit(double celsius)
        {
            double calc = (1.8 * celsius) + 32;
            return calc;
        }

        public static void Executar()
        {
            Console.WriteLine("Informe um valor em Fahrenheit!");
            double fahrenheit = double.Parse(Console.ReadLine());

            double resultado = Temperatura.ConverterParaCelsius(fahrenheit);
            Console.WriteLine($"O valor de {fahrenheit} se tornou {resultado:F2} em Celsius");

            Console.WriteLine();

            Console.WriteLine("Informe um valor em Celsius!");
            double celsius = double.Parse(Console.ReadLine());

            double resultado2 = Temperatura.ConverterParaFahrenheit(celsius);
            Console.WriteLine($"O valor de {celsius} se tornou {resultado2:F2} em Fahrenheit");

        }
    }
}
