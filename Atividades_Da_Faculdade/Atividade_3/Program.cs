using AtividadePOO.Classes;
using AtividadePOO.Excessoes;
using System;

public class Teste
{
    public static void Main(string[] args)
    {
        try
        {
            Agenda agenda = new Agenda();

            Pessoa p1 = new Pessoa("Enrique", "111", "Enrique@gmail.com", "a");
            Pessoa p2 = new Pessoa("Samuel", "222", "Samuel@gmail.com", "b");
            Pessoa p3 = new Pessoa("Daniel", "333", "Daniel@gmail.com", "c");
            Pessoa p4 = new Pessoa("Jeremias", "444", "Jeremias@gmail.com", "d");
            Pessoa p5 = new Pessoa("Wendell", "555", "Wendell@gmail.com", "e");

            agenda.InserirPessoa(p1);
            agenda.InserirPessoa(p2);
            agenda.InserirPessoa(p3);
            agenda.InserirPessoa(p4);
            agenda.InserirPessoa(p5);

            agenda.ImprimirPessoas();

            agenda.RemoverPessoa(p2);

            agenda.ImprimirPessoas();
        }

        catch (SenhaIncorretaException ex)
        {
            Console.WriteLine(ex.Message);
        }

        catch(PessoaNaoEncontradaException ex)
        {
            Console.WriteLine(ex.Message);
        }

        catch (PessoaJaExisteException ex)
        {
            Console.WriteLine(ex.Message);
        }

        catch (AgendaVaziaException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}