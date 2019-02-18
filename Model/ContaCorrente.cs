using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Model
{
    class ContaCorrente : Conta, ITributavel
    {
        public bool AtivoCorrente { get; set; }

        public ContaCorrente(int numero, Cliente titular, double saldo, bool ativoCorrente )
        {
            this.Numero = numero;
            this.Titular = titular;
            this.Saldo = saldo;
            this.AtivoCorrente = ativoCorrente;
        }
        public ContaCorrente()
        {

        }
        public override bool Saca(double valor)
        {
            return base.Saca(valor + CalcularTributo());
        }

        public override double CalcularTributo()
        {
            return this.Saldo * 0.05 ;
        }
        public override int VerificarConta(Conta c)
        {
            if (this.Equals(c))
            {
                return 1;
            }
            return 0;
        }
        
    }
}
