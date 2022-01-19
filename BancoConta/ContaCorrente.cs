using System;


namespace BancoConta
{
    public class ContaCorrente
    {
        public ContaCorrente(int agencia, int numeroDaConta)
        {
            if (agencia <= 0) 
            {
                throw new ArgumentException("O numero da agencia precisa ser maior que zero", nameof(agencia));
            }
            if (numeroDaConta <= 0) 
            {
                throw new ArgumentException("O numero da conta precisa ser maior que zero", nameof(numeroDaConta));
            }
            
            Agencia = agencia;
            NumeroConta = numeroDaConta;
            TotalDeContasCriadas++;
        }
        public static int TotalDeContasCriadas {get; private set;}
        public Cliente Titular {get; set;}
        public int NumeroConta { get; }
        public int Agencia { get; }
        

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
        

        public void Sacar(double valor)
        {
            if (0 > valor) 
            {
                throw new ArgumentException("Valor invalido para saque", nameof(valor));
            }
            if (valor > _saldo)
            {
                throw new SaldoInsuficienteException(Saldo, valor); 
            }

            _saldo -= valor;

        }
        public void Depositar(double valor)
        {
            if (0 > valor) 
            {
                throw new ArgumentException("Valor invalido para depósito.", nameof(valor));
            }
            _saldo += valor;
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {

            if (0 > valor)
            {
                throw new ArgumentException("Valor insuficiente para transferência.", nameof(valor));
            }
            try { Sacar(valor); }
            catch (SaldoInsuficienteException ex) 
            {
                throw new OperacaoFinanceiraException("Operacao nao realizada.", ex);
            }
            contaDestino.Depositar(valor);
        }
    }
}