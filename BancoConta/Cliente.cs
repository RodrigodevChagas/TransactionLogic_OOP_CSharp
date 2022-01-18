using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoConta
{
    public class Cliente
    {
        public Cliente(string cpf) { CPF = cpf;}
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public string Profissao { get; set; }

    }
}
