using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Model
{
    abstract class Conta
    {

        public int Numero { get; set; }
        public Cliente Titular { get; set; }
        public double Saldo { get; set; }

        protected Conta(int numero, Cliente titular, double saldo)
        {
            this.Numero = numero;
            this.Titular = titular;
            this.Saldo = saldo;
        }
        public Conta()
        {

        }

        public abstract double CalcularTributo();
        public virtual bool Saca(double valor)
        {
            if(this.Saldo >= valor)
            {
                this.Saldo -= valor;
                return true;
            }
            throw new Exception("Valor do saldo menor que do saque");
        }

        public virtual void Deposita(double valor)
        {
            if ((valor > 0) || (valor <= 10000))
            {
                this.Saldo += valor;
                return;
            }
            throw new Exception("Valor negativo ou muito alto");
        }

        public virtual void Transfere (double valor, Conta destino)
        {
            if (this.Saca(valor))
            {
                destino.Deposita(valor);
                return;
            }
            throw new Exception("Transferência não foi possível, valor não disponível"); 

            /*
            if(this.saldo >= valor)
            {
                this.saldo -= valor;
                destino.saldo -= valor;
            }
            */
        }

        public virtual int VerificarConta(Conta c)
        {

            return 1;
        }


    }
}
