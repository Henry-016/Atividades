using AtividadeDePOO___Padrões_de_Projeto.Interfaces;
using System;

namespace AtividadeDePOO___Padrões_de_Projeto.Classes
{
    public class ControleDocumentos : IDocumentos
    {
        private static ControleDocumentos _instancia;

        private static readonly object _lock = new object();

        private readonly IRelatorio _relatorio;
        private readonly ICarta _carta;

        private ControleDocumentos(IRelatorio relatorio, ICarta carta)
        {
            _relatorio = relatorio ?? throw new ArgumentNullException(nameof(relatorio));
            _carta = carta ?? throw new ArgumentNullException(nameof(carta));
            Console.WriteLine("ControleDocumentos: Nova instância criada e subsistemas configurados.");
        }

        public static ControleDocumentos GetInstance(IRelatorio relatorio, ICarta carta)
        {
            if (_instancia == null)
            {
                lock (_lock)
                {
                    if (_instancia == null)
                    {
                        _instancia = new ControleDocumentos(relatorio, carta);
                    }
                }
            }
            return _instancia;
        }

        public void GerarRelatorio()
        {
            _relatorio.GerarRelatorio();
        }

        public void GerarCarta(string texto, string destinatario)
        {
            _carta.GerarCarta(texto, destinatario);
        }
    }
}