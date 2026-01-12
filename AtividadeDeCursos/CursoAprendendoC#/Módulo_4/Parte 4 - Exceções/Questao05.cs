using System;

namespace Parte_4___Exceções.Questões
{
    public class LoginException : Exception
    {
        public LoginException()
        {

        }

        public LoginException(string mensagem) : base(mensagem)
        {

        }
    }

    public class Sistema
    {
        public string Usuario { get; private set; }
        public string Senha { get; private set; }
        public static int TentativasErradas { get; set;}

        public Sistema(string usuario, string senha)
        {
            Usuario = usuario;
            Senha = senha;
        }

        public void Logar(string usuario, string senha)
        {
            if (TentativasErradas >= 3)
            {
                throw new LoginException("Tentativas de Login Excedidas! Tente Novamente outra Hora!");
            }

            if (usuario == Usuario && senha == Senha)
            {
                Console.WriteLine($"Bem Vindo, {Usuario}!");
                return;
            }

            if(usuario != Usuario)
            {
                throw new ArgumentException("Incorreto! Argumento incorreto: ", nameof(usuario));
            }

            if(senha != Senha)
            {
                throw new ArgumentException("Incorreto! Argumento Incorreto:", nameof(senha));
            }
        }
    }
}

/*
 Sistema sis = new Sistema("Enrique", "Batata123");

            while(true)
            {
                try
                {
                    Console.WriteLine("Digite o Usuario: ");
                    string usuario = Console.ReadLine();
                    Console.WriteLine("Digite a Senha");
                    string senha = Console.ReadLine();
                    sis.Logar(usuario, senha);
                    break;
                }

                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Sistema.TentativasErradas += 1;
                }

                catch (LoginException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Encerrando PC!");
                    break;
                }
            }
 */
