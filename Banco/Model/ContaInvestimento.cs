using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Model
{
    class ContaInvestimento : Conta
    {
        public override double CalcularTributo()
        {
            return this.Saldo * 0.03;
        }
    }
}
