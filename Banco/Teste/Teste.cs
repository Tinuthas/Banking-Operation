using System;
using System.Collections.Generic;
using System.Text;
using Banco.Model;


namespace Banco
{
    class Teste
    {
        // Ctrl + r, Ctrl + r
        static void Main(string[] args)
        {
            Conta c = new ContaCorrente();
            Cliente cli = new Cliente("Sol")
            {
                // bloco de inicialização
                Cpf = "123.456.789-01",
                Rg = "21.345.987-x",
                Idade = 25
            };
            

            Console.WriteLine("\nPrograma Bancário\n");
            
            Console.WriteLine("Entrar (0) ou Nova Conta (1)");

            if (Convert.ToInt32(Console.ReadLine()) == 0)
            {
                Console.WriteLine("Informe seus Dados");
                Console.Write("Conta: ");
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("Não disponível");
                
            }

            Conta cc = new ContaCorrente();
            Conta cp = new ContaPoupanca();
            
            Console.Write("Qual tipo de conta: \n(0) Conta Corrente - (1) Conta Poupança: ");
            if(Convert.ToInt32(Console.ReadLine()) == 0)
            {
                Operacao(cc);
            }else
            {
                Operacao(cp);
            }

           


        }

        public static void Operacao(Conta c)
        {
            try
            {

                int aux = 0;
                do
                {
                    Console.Write("Escolha Operação: \n(1) Saldo - (2) Saque - (3) Deposito - (4) Transferência: ");

                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            Saldo(c);
                            break;
                        case 2:
                            Sacar(c);
                            break;
                        case 3:
                            Depositar(c);
                            break;
                        case 4:
                            Transferir(c);
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine("\n Quer Continuar? (0) Sair (1)");
                    if (Convert.ToInt32(Console.ReadLine()) != 1) { continue; }
                    aux++;
                }
                while (aux == 0);
            }
            catch (Exception ex)
            {

                Console.WriteLine("\nMessage --- {0}\n", ex.Message);

            }
        }

        public static void Saldo(Conta c)
        {
            Console.WriteLine(c.Saldo + "\n");
        }

        public static void Sacar(Conta c)
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

        public static void Depositar(Conta c)
        {

            Console.Write("Depósito: ");
            c.Deposita(Convert.ToDouble(Console.ReadLine()));

        }
        public static void Transferir(Conta c)
        {
            Conta outro = new ContaCorrente();
            Console.Write("Transferir: ");
            c.Transfere(Convert.ToDouble(Console.ReadLine()), outro);
        }
    }

}
