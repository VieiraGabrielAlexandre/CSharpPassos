using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 8");
            int idade = 10;
            int qtPessoas = 1;

            if (idade >= 18 || qtPessoas >= 2)
            {
                Console.WriteLine("João pode passar");
            } else
            {
                Console.WriteLine("João fica !");
            }

            bool onOff = true;

            Console.WriteLine("Sistema está ligado ? " + onOff);

            Console.ReadLine();
        }
    }
}
