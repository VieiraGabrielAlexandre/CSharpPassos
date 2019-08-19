using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Figuras");
            int contadorLinha;
            int contadorColuna;

            for (contadorLinha = 0;contadorLinha<10;contadorLinha++)
            {
                for (contadorColuna = 0;contadorColuna<10;contadorColuna++)
                {
                    Console.Write("*");
                    if (contadorColuna >= contadorLinha)
                        break;
                }
                Console.WriteLine();

            }
            Console.WriteLine("--------------");

            int contadorLinha2;
            int contadorColuna2;
            Console.WriteLine("--------------");


            for (contadorLinha2 = 0; contadorLinha2 < 10; contadorLinha2++)
            {
                for (contadorColuna2 = 10; contadorColuna2 < 0; contadorColuna2--)
                {
                    Console.Write("*");
                    if (contadorColuna2 <= contadorLinha2)
                        break;
                }
                Console.WriteLine();

            }

            Console.ReadLine();
        }
    }
}
