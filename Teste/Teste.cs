using System;
using System.Collections.Generic;
using System.Text;
using Banco.Model;
using System.IO;


namespace Banco
{
    class Teste
    {
        // Ctrl + r, Ctrl + r
        static void Main(string[] args)
        {
            Conta c = new ContaCorrente();
            Cliente cli = new Cliente()
            {
                // bloco de inicialização
                Cpf = "123.456.789-01",
                Rg = "21.345.987-x",
                Idade = 25
            };
            c.Titular = cli;
            c.Numero = 100;

            Dictionary<int, List<Conta>> CLIENTE = new Dictionary<int, List<Conta>>();

            List<Conta> lista = new List<Conta>();
            lista.Add(new ContaCorrente(100, new Cliente("Teste", "324.343.432.34", "34.234.231-4", 21), Convert.ToDouble(10000.00), true));
            lista.Add(new ContaPoupanca(100, new Cliente("Teste", "324.343.432.34", "34.234.231-4", 21), Convert.ToDouble(100), true));
            CLIENTE.Add(100, lista);
            List<Conta> lista2 = new List<Conta>();
            lista2.Add(new ContaCorrente(101, new Cliente("João", "686.756.434-76", "87.765.234-7", 65), Convert.ToDouble(100.00), true));
            lista2.Add(new ContaPoupanca(101, new Cliente("João", "686.756.434-76", "87.765.234-7", 65), Convert.ToDouble(500.00), true));
            CLIENTE.Add(101, lista2);
            List<Conta> lista3 = new List<Conta>();
            lista3.Add(new ContaCorrente(102, new Cliente("Maria", "126.754.114-16", "19.756.543-7", 30), Convert.ToDouble(300.00), true));
            CLIENTE.Add(102, lista3);
            List<Conta> lista4 = new List<Conta>();
            lista4.Add(new ContaPoupanca(103, new Cliente("Carlos", "126.754.114-16", "19.756.543-7", 30), Convert.ToDouble(160.00), true));
            CLIENTE.Add(103, lista4);



            try
            {

                Console.WriteLine("\nPrograma Bancário\n");

               

                var numero = 0;
                for (int i = 0; i == 0;)
                {
                    Console.Write("Entrar (0) ou Nova Conta (1)");
                    if (Convert.ToInt32(Console.ReadLine()) == 0)
                    {
                        Console.WriteLine("Informe seus Dados");
                        Console.Write("Número da Conta: ");
                        numero = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        if (ProcurarTitular(numero, CLIENTE))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Usuário não encontrado");
                        }
                        
                        Console.WriteLine("\n");
                    }
                    else
                    {
                        Console.WriteLine("Não disponível");
                        Console.WriteLine();
                    }
                }

                Conta cc = new ContaCorrente();
                Conta cp = new ContaPoupanca();

                List<Conta> conta = CLIENTE[numero];
                for (int i = 0; i < conta.Count; i++)
                {
                    if (conta[i].VerificarConta(conta[i]) == 1)
                    {
                        cc = conta[i];
                    }
                    else if (conta[i].VerificarConta(conta[i]) == 2)
                    {
                        cp = conta[i];
                    }
                }

              
               
                for(int i = 0; i == 0;)
                {
                    Console.Write("Qual tipo de conta: \n(0) Conta Corrente - (1) Conta Poupança: ");
                    var opcao = Convert.ToInt32(Console.ReadLine());
                    if (opcao == 0)
                    {
                        if(cc.Numero == 0)
                        {
                            Console.WriteLine("Conta Corrente Não Existe\n");
                            
                            continue;
                        }
                        Operacao(cc);
                    }
                    else if(opcao == 1)
                    {
                        if (cp.Numero == 0)
                        {
                            Console.WriteLine("Conta Poupança Não Existe\n");
                            continue;
                        }
                        Operacao(cp);
                    }else
                    {
                        Console.WriteLine("Escolheu nenhum\n");
                    }

                    Console.WriteLine("Deseja entrar em outra conta?");
                    Console.Write("Sim (0) Não (1): ");
                    if (Convert.ToInt32(Console.ReadLine()) == 0) continue;
                    i++;
                }



            }
            catch (Exception ex)
            {
                Console.WriteLine("\nMessage --- {0}\n", ex.Message);
            }
        }

        public static bool ProcurarTitular(int numero, Dictionary<int,List<Conta>> cliente)
        {
            if (!cliente.ContainsKey(numero)) return false;
            return true;


            /*
            var caminho = "C:\\Users\\DELL\\Desktop\\Projetos\\VisualStudio\\Projeto\\Banco\\Conta.txt";
            StreamReader leitor = File.OpenText(caminho);
            StringBuilder sb = new StringBuilder();
            while (leitor.EndOfStream != true)
            {

                sb.Append(leitor.ReadLine());
                
                //string linha = leitor.ReadLine();
                string[] dados = new string[sb.ToString().Split('=', ' ').Length];
                if ((!sb.ToString().Contains($"numeroC={numero}")) ^ (!sb.ToString().Contains($"numeroP={numero}")) continue;
                
                dados = sb.ToString().Split('=', ' ');
                Cliente cli = new Cliente();
                cli.Nome = dados[5];
                cli.Cpf = dados[7];
                cli.Rg = sb.ToString().Substring(sb.ToString().LastIndexOf("rg=") + 3, 12);
                Console.WriteLine(cli.Nome);
                Console.WriteLine(cli.Rg);
                //cli.Idade = Convert.ToInt32(dados[7]);
                return cli;
            } */

        
        }

        public static Conta NovaConta()
        {
            
            Console.WriteLine("Informe Seus Dados");
            Cliente cli = new Cliente();
            Console.Write("Nome: ");
            cli.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            cli.Idade = Convert.ToInt32(Console.ReadLine());
            Console.Write("CPF: ");
            cli.Cpf = Console.ReadLine();
            Console.Write("RG: ");
            cli.Rg = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Qual tipo de Conta?");
            Console.Write("Conta Corrente (0) - Conta Poupança (1)");
            var r = Convert.ToInt32(Console.ReadLine());
            if (r == 0)
            {
                Conta c = new ContaCorrente();
                c.Titular = cli;
                return c;
            }
            else if (r == 1)
            {
                Conta c = new ContaPoupanca();
                return c;
            }
            else
            {
                return null;
            }

        }

        public static void Operacao(Conta c)
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
                Console.Write("\n Quer Continuar (0) ou Sair (1): ");
                if (Convert.ToInt32(Console.ReadLine()) != 1) { continue; }
                aux++;
            }
            while (aux == 0);

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


