using AtividadeDePOO___Padrões_de_Projeto.Interfaces;
using System;
using System.Text;

namespace AtividadeDePOO___Padrões_de_Projeto.Classes
{
    public abstract class Relatorio : IRelatorio
    {
        public void GerarRelatorio()
        {
            Console.WriteLine("--- Gerando Relatório ---");
            GerarIntroducao();
            GerarCorpo();
            GerarConclusao();
            Console.WriteLine("--- Relatório Concluído ---\n");
        }

        protected abstract void GerarIntroducao();
        protected abstract void GerarCorpo();
        protected abstract void GerarConclusao();
    }

    public class RelatorioAcademico : Relatorio
    {
        protected override void GerarIntroducao()
        {
            Console.WriteLine("Introdução: Problemática, Proposta de solução e estrutura do trabalho");
        }

        protected override void GerarCorpo()
        {
            Console.WriteLine("Corpo: Trabalhos relacionados, Desenvolvimento do trabalho, avaliação sistemática");
        }

        protected override void GerarConclusao()
        {
            Console.WriteLine("Conclusão: Considerações finais e trabalhos futuros");
        }
    }

    public class RelatorioComercial : Relatorio
    {
        protected override void GerarIntroducao()
        {
            Console.WriteLine("Introdução: Público alvo, estimativa de custo e estimativa de receita");
        }

        protected override void GerarCorpo()
        {
            Console.WriteLine("Corpo: Plano de Negócio");
        }

        protected override void GerarConclusao()
        {
            Console.WriteLine("Conclusão: Considerações finais e tempo de retorno do investimento");
        }
    }
}