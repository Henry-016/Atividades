using System;
using AtividadePOO.Excessoes;

namespace AtividadePOO.Classes
{
    public class Agenda
    {
        private List<Pessoa> pessoas;

        public Agenda()
        {
            pessoas = new List<Pessoa>();
        }
        public void InserirPessoa(Pessoa pessoa)
        {
            foreach(Pessoa p in pessoas)
            {
                if(pessoa.GetEmail() == p.GetEmail())
                {
                    throw new PessoaJaExisteException("Já existe uma pessoa usando esse e-mail na Agenda!");
                }
            }

            pessoas.Add(pessoa);
            Console.WriteLine("Pessoa Adicionada com Sucesso! \n");
        }

        public void RemoverPessoa(Pessoa pessoa)
        {
            foreach(Pessoa p in pessoas)
            {
                if(pessoa.GetEmail() == p.GetEmail())
                {
                    pessoas.Remove(p);
                    Console.WriteLine("Pessoa Removida com Sucesso! \n");
                    return;
                }
            }

            throw new PessoaNaoEncontradaException("Essa Pessoa não está na Agenda!");
        }

        public void ImprimirPessoas()
        {
            if (pessoas.Count == 0)
            {
                throw new AgendaVaziaException("Não há ninguém na Agenda!");
            }

            foreach(Pessoa p in pessoas)
            {
                Console.WriteLine($"Nome: {p.GetNome()} / Telefone: {p.GetTelefone()} / E-mail: {p.GetEmail()}");
            }

            Console.WriteLine($"Total de pessoas: {pessoas.Count} \n");
        }
    }
}
