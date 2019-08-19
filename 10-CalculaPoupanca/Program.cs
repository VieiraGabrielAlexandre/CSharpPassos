using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 10");
            int contadorMes = 0;
            int numeroMes = 1;

            Console.WriteLine("Digite o valor de investimento = R$");
            double valorInvestido = Convert.ToDouble(Console.ReadLine());

            while (contadorMes < 12)
            {
                valorInvestido = valorInvestido + (valorInvestido * 0.0036);
                Console.WriteLine("Mês = " + numeroMes + "\nValor = "+valorInvestido);
                contadorMes++;
                numeroMes++;
            }
            Console.ReadLine();
        }
    }
}
