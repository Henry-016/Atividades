using ListaEncadeada___Aluno.Exceções;
using ListaEncadeada___Aluno.Lista;

public class Program
{
    public static void Main(string[] args)
    {
        ListaDeAlunos lista = new ListaDeAlunos();

        try
        {
            //lista.AdicionarAlunoInicio("2", 7.0);
            //lista.AdicionarAlunoFim("3", 9.2);
            lista.AdicionarAlunoInicio("1", 10);
            //lista.AdicionarAlunoFim("4", 2.4);
            //lista.RemoverAlunoInicio();
            lista.RemoverAlunoFim();
            lista.MostrarNotaDoAluno("1");
            lista.MostrarListaDeAlunos();
        }
        catch (AlunoNaoEncontrado ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}