using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoConta
{
    public class OperacaoFinanceiraException : Exception
    {

        public OperacaoFinanceiraException() { }
        public OperacaoFinanceiraException(string message) : base(message) { }
        public OperacaoFinanceiraException(string message, Exception InnerException) : base(message, InnerException) { }
    }
}
