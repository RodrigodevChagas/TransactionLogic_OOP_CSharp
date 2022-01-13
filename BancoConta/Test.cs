using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoConta
{
    internal class Test
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoSeth =  new ContaCorrente(303, 201529);
            Cliente seth = new Cliente();
            seth.Nome = "Seth";
            seth.CPF = "043.959.791-90";
            seth.Profissao = "Pro-Wrestler";

            contaDoSeth.Titular = seth;
            contaDoSeth.Saldo = 500.0;

            Cliente roman = new Cliente();
            roman.Nome = "Roman";
            roman.CPF = "296.054.231-20";
            roman.Profissao = "Pro-Wrestler";

            ContaCorrente contaDoRoman = new ContaCorrente(020, 201530);
            contaDoRoman.Titular = roman;
            contaDoRoman.Saldo = 1000.0;


            Console.WriteLine("Nome: " + contaDoSeth.Titular.Nome);
            Console.WriteLine("Agencia: " + contaDoSeth.Agencia);
            Console.WriteLine("Numero da Conta: " + contaDoSeth.NumeroConta);
            Console.WriteLine("Saldo: " + contaDoSeth.Saldo);
            Console.WriteLine("CPF: " + seth.CPF);

            Console.WriteLine();
            
            Console.WriteLine("Nome: " + contaDoRoman.Titular.Nome);
            Console.WriteLine("Agencia: " + contaDoRoman.Agencia);
            Console.WriteLine("Numero da Conta: " + contaDoRoman.NumeroConta);
            Console.WriteLine("Saldo: " + contaDoRoman.Saldo);
            Console.WriteLine("CPF: " + roman.CPF);

            contaDoSeth.Sacar(100);
            contaDoSeth.Depositar(100);
            Console.WriteLine();
            Console.WriteLine("Saldo do Seth é: " + contaDoSeth.Saldo);
            Console.WriteLine("Saldo do Roman é: " + contaDoRoman.Saldo);

            int valorTransferencia = 100;
            contaDoRoman.Transferir(valorTransferencia, contaDoSeth);
            Console.WriteLine();
            Console.WriteLine("O valor da transferencia de Roman para Seth é: " + valorTransferencia);
            Console.WriteLine("Saldo do Seth é: " + contaDoSeth.Saldo);
            Console.WriteLine("Saldo do Roman é: " + contaDoRoman.Saldo);

            Console.WriteLine();
            Console.WriteLine("O total de contas criadas no Banco foi de " + ContaCorrente.TotalDeContasCriadas + " contas");

            Console.ReadLine();

         
        }
    }
}
