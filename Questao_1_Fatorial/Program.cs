using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = -1;
            int resultado;
 
            resultado = Calcular(numero);

            Console.WriteLine("Resultado: {0}", resultado);
            Console.ReadKey();
        }

        static int Calcular(int numero)
        {
            int resultado; 

            if (numero <= 1)
            {
                return (1);
            }
            else
            {
                resultado = numero * Calcular(--numero);
                return resultado;
            }

        }
    }
}
