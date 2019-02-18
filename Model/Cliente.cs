using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Model
{
    class Cliente
    {

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public int Idade { get; set; }

        public Cliente()
        {
        }
        public Cliente(string nome, string cpf, string rg, int idade)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Rg = rg;
            this.Idade = idade;
        }

        

        public bool EhMenorDeIdade()
        {
            if (this.Idade >= 18) { return true; }
            return false;
        }
    }

    
}
