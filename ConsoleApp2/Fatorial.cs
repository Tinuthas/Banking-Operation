using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Fatorial
    {
        static void Main(string[] args)
        {
            Console.Write("Insira...");
            int n = Convert.ToInt32(Console.ReadLine());

            n = VerificarSequencia(n);

            int[] f = new int[n];

            MostrarSequencia(f);
        }

        public static int VerificarSequencia(int n)
        {
            if( n <= 0) { Console.WriteLine("Número da Sequência menor inválido"); return 0; }
            if( n >= 100) { return n = 100; }
            return n;
        }

        public static void MostrarSequencia(int[] f)
        {
            f[0] = 0;
            f[1] = 1;
            Console.Write(f[0] +" "+ f[1]+ " ");
            for (int i = 2; i < f.Length; i++)
            {
                f[i] = f[i - 1] + f[i - 2];
                Console.Write(f[i] + " ");
            }
        }
    }
}
