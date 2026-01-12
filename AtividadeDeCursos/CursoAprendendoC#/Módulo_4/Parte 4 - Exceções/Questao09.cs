using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_4___Exceções.Questões
{
    public class ErroDeReserva : Exception
    {
        public ErroDeReserva()
        {

        }

        public ErroDeReserva(string message) : base(message)
        {

        }

        public ErroDeReserva(string message, Exception ex) : base(message, ex)
        {

        }
    }

    public class ReservaInvalidaException : Exception
    {
        public ReservaInvalidaException()
        {

        }

        public ReservaInvalidaException(string message) : base(message)
        {

        }
    }

    public class ReservaHotel
    {
        public string NomeDoHospede {  get; set; }
        public int NumeroDoQuarto { get; set; }
        public int DiasDaHospedagem { get; set; }

        public void Reservar(string nomeDoHospede, int numeroDoQuarto, int diasDaHospedagem)
        {
            if (nomeDoHospede == null || nomeDoHospede.Length == 0)
            {
                throw new ArgumentException("Nome Inválido! Digite Novamente!");
            }

            if (numeroDoQuarto <= 0)
            {
                var excecaoInterna = new ReservaInvalidaException($"Numero Inválido! {numeroDoQuarto} não é válido!");

                throw new ErroDeReserva("Erro! Digite Novamente!", excecaoInterna);
            }

            if (diasDaHospedagem <= 0)
            {
                var excecaoInterna = new ReservaInvalidaException($"Numero Inválido! {diasDaHospedagem} não é válido!");
                throw new ErroDeReserva("Erro! Digite Novamente!", excecaoInterna);
            }

            NomeDoHospede = nomeDoHospede;
            NumeroDoQuarto = numeroDoQuarto;
            DiasDaHospedagem = diasDaHospedagem;
        }
    }
}

/*
 ReservaHotel teste = new ReservaHotel();

            try
            {
                teste.Reservar("Enrique", 12, 3);
                Console.WriteLine(teste.NomeDoHospede);
                Console.WriteLine(teste.NumeroDoQuarto);
                Console.WriteLine(teste.DiasDaHospedagem);
            }

            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch(ErroDeReserva ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
            }
 */
