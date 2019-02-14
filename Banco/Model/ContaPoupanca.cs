using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Model
{
    class ContaPoupanca : Conta, ITributavel
    {
        public override bool Saca(double valor)
        {
            return base.Saca(valor + CalcularTributo());
        }

        public override void Deposita(double valor)
        {
            base.Deposita(valor - (0.10 * valor));
        }

        public void CalcularRendimento()
        {

        }

        public override double CalcularTributo()
        {
            return this.Saldo * 0.02;
        }

    }
}
