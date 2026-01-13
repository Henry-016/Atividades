using System;

namespace ListaEncadeada___Aluno.Exceções
{
    /// <summary>
    /// Representa a Ausência de um Aluno na Lista.
    /// </summary>
    public class AlunoNaoEncontrado : Exception
    {
        /// <summary>
        /// Construtor Padrão.
        /// </summary>
        public AlunoNaoEncontrado()
        {

        }

        /// <summary>
        /// Construtor que passa uma Mensagem.
        /// </summary>
        /// <param name="mensagem">Mensagem Amigavel</param>
        public AlunoNaoEncontrado(string mensagem) : base(mensagem)
        {

        }
    }
}
