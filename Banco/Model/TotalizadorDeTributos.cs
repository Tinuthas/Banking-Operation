using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Model
{
    class TotalizadorDeTributos
    {
        public readonly string nome = "João";
        
        public double Total { get; private set; }

        public void Acumula(Conta c)
        {
            Total += c.CalcularTributo();
        }

        public void Adiciona(ITributavel t)
        {
            this.Total += t.CalcularTributo();
        }


    }
}
