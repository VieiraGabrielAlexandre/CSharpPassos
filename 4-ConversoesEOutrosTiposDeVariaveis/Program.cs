using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 4");
            double salario;
            salario = 1200.50;

            //O int suporte valores até 32 bits
            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;

            Console.WriteLine("Salario em Inteiro = " + salarioEmInteiro + "\n" +"Salario em Double = " + salario);

            //O long suporta até 64 bits
            long idade;
            idade = 1300000000000;
            Console.WriteLine("Idade do universo é " + idade);

            //O short suporte até 16 bits
            short numero;
            numero = 1500;
            Console.WriteLine("Numero em short = " + numero);

            float numeroFloat = 15.80f;
            Console.WriteLine("Numero em float = " + numeroFloat);
            Console.ReadLine();
        }
    }
}
