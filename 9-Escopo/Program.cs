using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 9");
            bool status = true;

            Console.Write("Status do sistema :");

            if (status == true)
                Console.WriteLine("Ligado");
            else
                Console.WriteLine("Desligado");

            Console.ReadLine();
        }
    }
}
