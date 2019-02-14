using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Banco
{
    class Conta
    {

        public int numero;
        public string titular;
        public double saldo = 100;

        public bool Saca(double valor)
        {
            if(this.saldo >= valor)
            {
                this.saldo -= valor;
                return true;
            }
            return false;
        }

        public void Deposita(double valor)
        {
            this.saldo += valor;
        }

        public void Transfere (double valor, Conta destino)
        {
            if (this.Saca(valor))
            {
                destino.Deposita(valor);
            }
            /*
            if(this.saldo >= valor)
            {
                this.saldo -= valor;
                destino.saldo -= valor;
            }
            */
        }

        public double Saldo()
        {
            return this.saldo;
        }
    }
}
