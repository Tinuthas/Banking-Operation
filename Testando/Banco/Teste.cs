using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Banco
{
    class Teste
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();


            int aux = 0;
            do
            {
                Console.Write("Escolha o programa - (0) Sair? - (1) Saldo - (2) Saque - (3) Deposito - (4) Transferência: ");
                Console.WriteLine("Quer Sair? (0) ");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 0:
                        aux++;
                        break;
                    case 1:
                        Saldo(c);
                        break;
                    case 2:
                        Aumentar(c);
                        break;
                    case 3:
                        Diminuir(c);
                        break;
                    case 4:
                        Trocar(c);
                        break;
                    default:
                        break;
                }
                if (Convert.ToInt32(Console.ReadLine()) != 0) { continue; }
                aux++;
            }
            while (aux == 0);
        }

        public static void Saldo(Conta c)
        {
            Console.WriteLine(c.Saldo() + "\n");
        }

        public static void Aumentar(Conta c)
        {

            Console.Write("Saque: ");
            if (c.Saca(Convert.ToDouble(Console.ReadLine())))
            {
                Console.WriteLine("Saque realizado com sucesso");
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente");
            }

        }

        public static void Diminuir(Conta c)
        {

            Console.Write("Depósito: ");
            c.Deposita(Convert.ToDouble(Console.ReadLine()));

        }
        public static void Trocar(Conta c)
        {
            Conta outro = new Conta();
            Console.Write("Transferir: ");
            c.Transfere(Convert.ToDouble(Console.ReadLine()), outro);

        }
    }

}
