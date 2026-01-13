using System;

namespace ProjetinDePOO.Entidades
{
    /// <summary>
    /// Representa a entidade Autor.
    /// </summary>
    public class Autor : Pessoa
    {
        /// <summary>
        /// Instancia um objeto do tipo Autor.
        /// </summary>
        /// <param name="nome">Nome do Autor.</param>
        public Autor(string nome) : base(nome) {}
    }
}
