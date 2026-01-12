using System;

namespace Parte_4___Exceções.Questões
{
    public class ConversorException : Exception
    {
        public ConversorException()
        {

        }

        public ConversorException(string message) : base(message)
        {

        }
    }

    public class CelsiusParaKelvin
    {
        public void Converter(double Celsius)
        {
            if(Celsius < -273.15)
            {
                throw new ConversorException("A temperatura não pode ser menor que o Fucking Zero Absoluto!");
            }

            Console.WriteLine($"A Temperatura em Kelvin é: {Celsius + 273.15}");
        }
    }
}

/*
 CelsiusParaKelvin conv = new CelsiusParaKelvin();

            try
            {
                conv.Converter(-459);
            }

            catch(ConversorException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
 */
