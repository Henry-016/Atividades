using AtividadeDePOO___Padrões_de_Projeto.Classes;
using AtividadeDePOO___Padrões_de_Projeto.Interfaces;

namespace AtividadeDePOO___Padrões_de_Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("Demonstração dos Padrões de Projeto (Façade, Singleton, Template Method)");
            Console.WriteLine("==================================================\n");

            IRelatorio relatorioEscolhido = new RelatorioAcademico();
            ICarta cartaEscolhida = new CartaInformal();

            Console.WriteLine("--- 1. Obtendo a instância da Façade (Singleton) ---");

            ControleDocumentos facade1 = ControleDocumentos.GetInstance(relatorioEscolhido, cartaEscolhida);

            ControleDocumentos facade2 = ControleDocumentos.GetInstance(new RelatorioComercial(), new CartaFormal());

            Console.WriteLine($"Facade 1 é a mesma que Facade 2? {(facade1 == facade2 ? "Sim" : "Não")} (Padrão Singleton)");
            Console.WriteLine("\n----------------------------------------------------\n");


            Console.WriteLine("--- 2. Gerando Relatório Acadêmico (Façade + Template Method) ---");

            facade1.GerarRelatorio();

            Console.WriteLine("\n----------------------------------------------------\n");

            Console.WriteLine("--- 3. Gerando Carta Informal (Façade + Template Method) ---");

            string textoCarta = "Gostaria de atualizar sobre o nosso encontro.";
            string destinatarioCarta = "Enrique Ferreira da Silva";
            facade1.GerarCarta(textoCarta, destinatarioCarta);

            Console.WriteLine("\n----------------------------------------------------\n");

            IRelatorio relatorioComercial = new RelatorioComercial();
            ICarta cartaFormal = new CartaFormal();

            Console.WriteLine("--- 4. Tentativa de Gerar Documento com Subclasses Diferentes (Façade + Template Method) ---");
            Console.WriteLine("Resultado: A Façade continua usando RelatorioAcademico/CartaInformal definidos na inicialização.");

            facade1.GerarRelatorio();
        }
    }
}

