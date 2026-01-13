using System;
using AtividadePOO.Excessoes;

namespace AtividadePOO.Classes
{
    public class Pessoa
    {
        private string nome;
        private string telefone;
        private string email;
        private string senha;

        public Pessoa(string nomeDaPessoa, string telefoneDaPessoa, string emailDaPessoa, string senhaDaPessoa)
        {
            nome = nomeDaPessoa;
            telefone = telefoneDaPessoa;
            email = emailDaPessoa;
            senha = senhaDaPessoa;
        }

        public string GetNome()
        {
            return nome;
        }

        public string GetTelefone()
        {
            return telefone;
        }

        public string GetEmail()
        {
            return email;
        }

        public void ValidarSenha(string senhaTentativa)
        {
            if (senhaTentativa == senha)
            {
                Console.WriteLine("Validado com sucesso!");
                return;
            }

            throw new SenhaIncorretaException("Senha Inválida! Tente novamente.");
        }
    }
}
