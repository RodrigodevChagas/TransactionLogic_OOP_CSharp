using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoConta
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        public SaldoInsuficienteException() { }
        public double Saldo{get;}
        public double ValorSaque{get;}
        public SaldoInsuficienteException(double saldo, double valor) : this("Tentativa de saque no valor de " + valor + " em um saldo de " + saldo)
        {
            Saldo = saldo;
            ValorSaque = valor;
        }
        public SaldoInsuficienteException(string Message) : base(Message) { }

        public SaldoInsuficienteException(string Message, Exception InnerException) : base(Message, InnerException) { }

    }
}
