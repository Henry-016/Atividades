using ListaEncadeada___Aluno.Exceções;
using System;

namespace ListaEncadeada___Aluno.Lista
{
    /// <summary>
    /// Representa uma Lista onde Contém todos os Alunos com suas Respectivas Matriculas e Nota.
    /// </summary>
    public class ListaDeAlunos
    {
        /// <summary>
        /// Guarda o Primeiro Aluno da Lista.
        /// </summary>
        public Aluno inicio;
        /// <summary>
        /// Guarda o Último Aluno da Lista.
        /// </summary>
        public Aluno fim;

        /// <summary>
        /// Inicializa os Atributos Inicio e Fim.
        /// </summary>
        public ListaDeAlunos()
        {
            inicio = null;
            fim = null;
        }

        /// <summary>
        /// Adiciona um Novo Aluno ao Inicio da Lista.
        /// </summary>
        /// <param name="matricula">Código que Referencia o Aluno da Instituição.</param>
        /// <param name="nota">Nota do Aluno.</param>
        public void AdicionarAlunoInicio(string matricula, double nota)
        {
            Aluno novoAluno = new Aluno(matricula, nota); // Inicializa o novo Aluno.

            if (inicio == null) // Verifica se a Lista é Vazia. Se for, tudo será o Primeiro Aluno.
            {
                novoAluno.proximo = novoAluno;
                novoAluno.anterior = novoAluno;
                inicio = novoAluno;
                fim = novoAluno;
                return;
            }

            // Caso a Lista não seja Vazia, faz as mudanças dos Ponteiros.

            novoAluno.proximo = inicio;
            novoAluno.anterior = fim;

            inicio.anterior = novoAluno;
            fim.proximo = novoAluno;

            inicio = novoAluno;
        }

        /// <summary>
        /// Adiciona um Novo Aluno ao Fim da Lista.
        /// </summary>
        /// <param name="matricula">Código que Referencia o Aluno da Instituição.</param>
        /// <param name="nota">Nota do Aluno.</param>
        public void AdicionarAlunoFim(string matricula, double nota)
        {
            Aluno novoAluno = new Aluno(matricula, nota); // Inicializa o novo Aluno.

            if (inicio == null) // Verifica se a Lista é Vazia. Se for, tudo será o Primeiro/Último Aluno.
            {
                novoAluno.proximo = novoAluno;
                novoAluno.anterior = novoAluno;
                inicio = novoAluno;
                fim = novoAluno;
                return;
            }

            // Caso a Lista não seja Vazia, faz as mudanças dos Ponteiros.

            novoAluno.proximo = inicio;
            novoAluno.anterior = fim;

            fim.proximo = novoAluno;
            inicio.anterior = novoAluno;

            fim = novoAluno;
        }

        /// <summary>
        /// Remove o Primeiro Aluno da Lista.
        /// </summary>
        public void RemoverAlunoInicio()
        {
            if (inicio == null) // Verifica se a Lista é Vazia.
            {
                Console.WriteLine("Lista Vazia!");
                return;
            }

            if (inicio == fim) // Verifica se Existe Apenas um Aluno na Lista. Caso seja, tornará a Lista Vazia.
            {
                inicio = null;
                fim = null;
                return;
            }

            // Caso Contrário, faz as mudanças dos Ponteiros.

            inicio = inicio.proximo;
            inicio.anterior = fim;
            fim.proximo = inicio;

        }

        /// <summary>
        /// Remove o último Aluno da Lista.
        /// </summary>
        public void RemoverAlunoFim()
        {
            if (inicio == null) // Verifica se a Lista é Vazia.
            {
                Console.WriteLine("Lista Vazia!");
                return;
            }

            if (fim == inicio) // Verifica se Existe Apenas um Aluno da Lista. Caso seja, tornará a Lista Vazia
            {
                inicio = null;
                fim = null;
                return;
            }

            // Caso Contrário, faz as mudanças dos Ponteiros.

            fim = fim.anterior;
            fim.proximo = inicio;
            inicio.anterior = fim;
        }

        /// <summary>
        /// Procura um Aluno por sua Matrícula e Mostra sua Nota.
        /// </summary>
        /// <param name="matricula">Código que Referencia o Aluno da Instituição.</param>
        public void MostrarNotaDoAluno(string matricula)
        {
            if (inicio == null) // Verifica se a Lista é Vazia.
            {
                Console.WriteLine("Lista Vazia!");
                return;
            }

            Aluno atual = inicio; // Inicializa o Primeiro Aluno.

            do // Como informei na atividade anterior, estou usando o Do-While por ser eficiente na questão de Lista Circular, mas ainda quero testar o For e While
            {
                if(atual.Matricula == matricula)
                {
                    Console.WriteLine($"Aluno com Matricula: {atual.Matricula}, encontrado!");
                    Console.WriteLine($"Nota: {atual.Nota:F2}");
                    Console.WriteLine();
                    return;
                }
                
                atual = atual.proximo;
            }
            while (atual != inicio);

            throw new AlunoNaoEncontrado($"Aluno com a Matrícula: {matricula} não foi encontrado. Verifique se a Matrícula é válida ou se o estudante não saiu da Instituição");
        }

        /// <summary>
        /// Mostra a Lista dos Alunos em Ordem.
        /// </summary>
        public void MostrarListaDeAlunos()
        {
            if (inicio == null) // Verifica se a Lista é Vazia.
            {
                Console.WriteLine("Lista Vazia!");
                return;
            }

            Aluno atual = inicio; // Inicializa o Primeiro Aluno.

            do
            {
                Console.WriteLine($"Matricula: {atual.Matricula}");
                Console.WriteLine($"Nota: {atual.Nota:F2}");
                Console.WriteLine();
                atual = atual.proximo;
            }
            while (atual != inicio);
        }
    }
}
