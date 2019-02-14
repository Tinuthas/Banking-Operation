using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Model
{
    class ContaCorrente : Conta, ITributavel
    {
        public override bool Saca(double valor)
        {
            return base.Saca(valor + CalcularTributo());
        }

        public override double CalcularTributo()
        {
            return this.Saldo * 0.05 ;
        }
        
    }
}
