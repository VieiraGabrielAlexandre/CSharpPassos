using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 7");
            int idade = 16;
            int qtPessoas = 1;
            if (idade <= 18 && qtPessoas >= 2)
            {
                Console.WriteLine("João é menor de idade");
            } else
            {
                Console.WriteLine("João é maior de idade");
            }
            if(qtPessoas >= 2)
            {
                Console.WriteLine("Porém joão esta acompanhado");
            }
            else
            {
                Console.WriteLine("João está sozinho");
            }

            Console.ReadLine();
        }
    }
}
