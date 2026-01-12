using System;

namespace Parte_4___Exceções.Questões
{
    public class IndiceException : Exception
    {
        public IndiceException()
        {

        }
        public IndiceException(string mensagem) : base(mensagem)
        {

        }
    }
    public class ListaDeNomes
    {
        public List<string> lista;
        
        public ListaDeNomes(params string[] nomes)
        {
            lista = new List<string>();
            lista.AddRange(nomes);
        }

        public void ProcurarNomes(string nome)
        {
            int teste = lista.IndexOf(nome);

            if(teste == -1)
            {
                throw new IndiceException("Nome não está presente na lista! Tente Novamente!");
            }

            Console.WriteLine($"{nome} está presente na lista!");
        }
    }
}

/*
 ListaDeNomes lista = new ListaDeNomes("Enrique", "Pedro", "Ana", "João", "Maria", "Sofia");

            try
            {
                lista.ProcurarNomes("Thiago");
            }
            
            catch(IndiceException ex)
            {
                Console.WriteLine(ex.Message);

                Console.WriteLine();
                Console.WriteLine("Os Nomes que Temos é:");
                Console.WriteLine();

                foreach (var nome in lista.lista)
                {
                    Console.WriteLine(nome);
                }
            }
 */
