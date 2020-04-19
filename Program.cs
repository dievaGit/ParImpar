using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero = 0;

            Console.Write("Escriba un numero positivo:");
            numero = Convert.ToDouble(Console.ReadLine());

            if(numero > 0)
             {
               if(numero % 2 == 0)
                {
                    Console.WriteLine("El numero: {0} es par", numero);
                }
               else
                {
                    Console.WriteLine("El numero: {0} es impar", numero);
                }
                          
             }
            else
            {
                Console.WriteLine("El numero no es valido");
            }

            Console.ReadKey();

        }
    }
}
