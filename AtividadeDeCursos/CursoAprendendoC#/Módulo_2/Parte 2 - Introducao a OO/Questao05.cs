using System;

namespace Parte_2___Introducao_a_OO.Parte_2___Introducao_a_OO
{
    public class Cliente
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }

        private static int TotalDeClientes = 0;

        public Cliente(string nome, string email)
        {
            Nome = nome;
            Email = email;

            TotalDeClientes++;
        }

        public static void Executar()
        {
            Cliente cliente1 = new Cliente("Enrique", "abc@gmail.com");
            Cliente cliente2 = new Cliente("Pedro", "def@gmail.com");
            Cliente cliente3 = new Cliente("Ana", "ghi@gmail.com");

            Console.WriteLine($"Temos {Cliente.TotalDeClientes} clientes ativos!");
        }
    }
}
