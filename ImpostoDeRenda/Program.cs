using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoDeRenda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o salario");
            double salario = Convert.ToDouble(Console.ReadLine());
            if (salario >= 1903.98 && salario <= 2826.65)
            {
                Console.WriteLine("Salario = "+salario+" \nAliquota = 7,5%\nDeclaração de R$142,80");
            }
            else if (salario >= 2826.66 && salario <= 3751.05)
            {
                Console.WriteLine("Salario = " + salario + " \nAliquota = 15%\nDeclaração de R$354,80");

            }
            else if (salario >= 3751.06 && salario <= 4664.68)
            {
                Console.WriteLine("Salario = " + salario + " \nAliquota = 22,5%\nDeclaração de R$636,13");

            }
            else if (salario >= 4664.69)
            {
                Console.WriteLine("Salario = " + salario + " \nAliquota = 27,5%\nDeclaração de R$869,36");

            }
            Console.ReadLine();
        }
    }
}
