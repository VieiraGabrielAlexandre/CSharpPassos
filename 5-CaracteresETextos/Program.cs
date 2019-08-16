using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 5");
            char PrimeiraLetra = 'G';
            Console.WriteLine(PrimeiraLetra);

            PrimeiraLetra = (char)65;
            Console.Write(PrimeiraLetra);
            PrimeiraLetra = (char)66;
            Console.WriteLine(PrimeiraLetra);

            string Nome = "Gabriel";
            Console.WriteLine("Primeiro Nome:" +Nome);

            string NomeCompleto = "Gabriel Alexandre Vieira";
            Console.WriteLine("Nome Completo: " + NomeCompleto + " \nIdade: " + 23);
            Console.ReadLine();
        }
    }
}
