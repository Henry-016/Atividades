using System;

namespace Parte_4___Exceções.Questões
{

    public class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException()
        {

        }

        public SaldoInsuficienteException(string message) : base(message)
        {

        }

        public SaldoInsuficienteException(string message, Exception ex) : base(message, ex)
        {

        }
    }

    public class ValorInvalidoException : Exception
    {
        public ValorInvalidoException()
        {

        }

        public ValorInvalidoException(string message) : base(message)
        {

        }
    }

    public class ByteBank
    {
        public double Saldo { get; private set; }

        public ByteBank(double saldo)
        {
            Saldo = saldo;
        }
        public void Sacar(double valor)
        {
            if (valor <= 0)
            {
                throw new ValorInvalidoException($"Valor Inválido para Saque, tente novamente! Valor Digitado: {valor}");
            }

            if (valor > Saldo)
            {
                throw new SaldoInsuficienteException($"Valor em conta é Insuficiente! Tente novamente!");
            }

            Saldo -= valor;
            Console.WriteLine("Saque Realizado com Sucesso!");
        }
    }


}

/*
 ByteBank byteBank = new ByteBank(200);

            try
            {
                byteBank.Sacar(2000);
            }

            catch(ValorInvalidoException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch(SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
            }
 */
