using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplicador;
            int numero = 0;
            int numeroTabuada;
            Console.WriteLine("!Tabuada do 0 ao 10 !\n");
            for (numeroTabuada = 0; numeroTabuada <= 10; numeroTabuada++)
            {
                for (multiplicador = 0; multiplicador <= 10; multiplicador++)
                {
                    Console.WriteLine(numeroTabuada + " * " + numero + " = " + (numeroTabuada * numero));
                    
                    if (numero == 10)
                    {
                        numero = 0;
                    }
                    numero++;

                }
            }
            Console.ReadLine();
        }
    }
}
