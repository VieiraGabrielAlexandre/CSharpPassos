using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criando Variaveis");

            int idade = 23;
            Console.WriteLine("Minha idade é " + idade);

            string nome = "Gabriel";
            Console.WriteLine("Meu nome é " + nome);

            int soma = 10 + 10 * 2;
            Console.WriteLine("Calculo = " + soma);
            Console.ReadLine();
        }
    }
}
