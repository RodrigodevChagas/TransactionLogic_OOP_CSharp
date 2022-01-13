using System;


namespace BancoConta
{
    public class ContaCorrente
    {
        public ContaCorrente (int agencia, int numeroDaConta)
        {
            Agencia = agencia;
            NumeroConta = numeroDaConta;
            TotalDeContasCriadas++;
        }
        public static int TotalDeContasCriadas {get; private set;}
        public Cliente Titular {get; set;}
        public int NumeroConta {get; set;}
        private int _agencia; 
        public int Agencia 
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                _agencia = value;
            }
        }

        private double _saldo;
        public double Saldo
        {
            get { return _saldo; }
            set
            {
                if (_saldo < 0)
                    {return;}
                else
                    { _saldo = value;}
            }
        }
        

        public bool Sacar(double valor)
        {
            if (valor > this._saldo)
            {
                return false;
            }

            _saldo -= valor;
            return true;

        }
        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor > _saldo)
            {
                return false;
            }
            contaDestino.Depositar(valor);
            _saldo -= valor;
            return true;
        }
    }
}