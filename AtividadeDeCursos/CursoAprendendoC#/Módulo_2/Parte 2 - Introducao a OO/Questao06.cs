using System;

namespace Parte_2___Introducao_a_OO.Parte_2___Introducao_a_OO
{
    public class ContaBancaria
    {
        public string Titular { get; set; }
        public double Saldo { get; private set; }
        
        public ContaBancaria(string titular, double saldo)
        {
            Titular = titular;
            
            if(saldo < 0)
            {
                Saldo = 0;
            }
            else
            {
                Saldo = saldo;
            }
        }

        public bool Depositar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor Inválido!");
                return false;
            }

            Saldo += valor;
            Console.WriteLine("Depósito Realizado!");
            return true;
        }

        public bool Sacar(double valor)
        {
            if(valor > Saldo)
            {
                Console.WriteLine("Saque Inválido!");
                return false;
            }

            Saldo -= valor;
            Console.WriteLine("Saque Realizado!");
            return true;
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine(Saldo);
        }

        public static void Executar()
        {
            ContaBancaria conta1 = new ContaBancaria("Enrique", -400);

            Console.WriteLine($"Saldo Inicial: {conta1.Saldo}");

            conta1.Depositar(1500);

            Console.WriteLine($"Saldo Após Depósito: {conta1.Saldo}");

            conta1.Sacar(400);

            Console.WriteLine($"Saldo Após Saque: {conta1.Saldo}");
        }
    }
}
