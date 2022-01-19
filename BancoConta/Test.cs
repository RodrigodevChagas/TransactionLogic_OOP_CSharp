using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoConta
{
    public class Test
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoSeth =  new ContaCorrente(303, 201529);
            Cliente seth = new Cliente("043.959.791-90");
            seth.Nome = "Seth";
            seth.Profissao = "Pro-Wrestler";

            contaDoSeth.Titular = seth;
            contaDoSeth.Saldo = 500.0;

            Cliente roman = new Cliente("296.054.231-20");
            roman.Nome = "Roman";
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

           
            int valorTransferencia = 10000000;
            try {contaDoRoman.Transferir(valorTransferencia, contaDoSeth); }
            catch (OperacaoFinanceiraException e) 
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
                Console.WriteLine(e.InnerException.Message);
                
            }
            Console.WriteLine();
            Console.WriteLine("Saldo do Seth é: " + contaDoSeth.Saldo);
            Console.WriteLine("Saldo do Roman é: " + contaDoRoman.Saldo);

            Console.WriteLine();
            Console.WriteLine("O total de contas criadas no Banco foi de " + ContaCorrente.TotalDeContasCriadas + " contas");
            Console.WriteLine();
           
            
            Console.ReadLine();


         
        }
        
    }
}
