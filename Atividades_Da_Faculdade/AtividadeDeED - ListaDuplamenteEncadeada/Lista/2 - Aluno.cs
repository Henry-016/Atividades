using System;

namespace ListaEncadeada___Aluno.Lista
{
    /// <summary>
    /// Representa um Aluno.
    /// </summary>
    public class Aluno
    {
        /// <summary>
        /// Guarda o Código que Referencia o Aluno da Instituição.
        /// </summary>
        public string Matricula;
        /// <summary>
        /// Guarda a Nota do Aluno.
        /// </summary>
        public double Nota;
        /// <summary>
        /// Ponteiro que Indica o Próximo Aluno da Lista.
        /// </summary>
        public Aluno proximo;
        /// <summary>
        /// Ponteiro que Indica o Aluno Anterior da Lista.
        /// </summary>
        public Aluno anterior;

        /// <summary>
        /// Inicializa os Atributos Matricula e Nota.
        /// </summary>
        /// <param name="matricula">Código que Referencia o Aluno da Instituição.</param>
        /// <param name="nota">Nota do Aluno.</param>
        public Aluno(string matricula, double nota)
        {
            Matricula = matricula;
            Nota = nota;
            proximo = null;
            anterior = null;
        }
    }
}
