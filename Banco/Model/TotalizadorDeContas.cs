using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Model
{
    class TotalizadorDeContas
    {
        public double ValorTotal { get; private set; }

        public void Soma(Conta conta)
        {
            ValorTotal += conta.Saldo;
        }

        public double SaldoTotal (Conta conta)
        {
            return ValorTotal += conta.Saldo;
        }
    }
}
