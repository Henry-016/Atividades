using ProjetinDePOO.Excecoes;
using ProjetinDePOO.FactoryMethod;
using ProjetinDePOO.Façade;
using ProjetinDePOO.Repository;
using ProjetinDePOO.Entidades;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            IPublicacaoRepository pubRep = new PublicacaoRepository();
            ILeitorRepository leitorRep = new LeitorRepository();
            Biblioteca biblioteca = new Biblioteca("123", "Rua Nossa Senhora da Selete", "Biblioteca do Seu Zé", "456");
            GerenciadorDeServicos gerenciadorDeServicos = new GerenciadorDeServicos(pubRep, leitorRep, biblioteca
                
                );
            GerenciadorFachada gerenciador = new GerenciadorFachada(gerenciadorDeServicos);

            PublicacaoFactory publicacaoFactory = new PublicacaoFactory();
            PessoaFactory pessoaFactory = new PessoaFactory();

            InterfaceUsuario inter = new InterfaceUsuario(gerenciador, publicacaoFactory, pessoaFactory);

            inter.Iniciar();
        }

        catch (LeitorJaCadastradoException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (LeitorNaoCadastradoException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (LivroJaExistenteException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (LivroNaoEncontradoException ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}

// O QUE DEVO FAZER / CORRIGIR?


// Ajustar e Corrigir o UML!


// Ler todo o código e verificar o que não entendi e pedir pro Gemini me ensinar!

// Por último, Documentar Tudo! --- Validar com Professor isso!