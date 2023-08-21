using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    public class Operaciones
    {
        public void DivisionConExcepcion(int valor)
        {
            try
            {
                int resultado = 10 / valor;
                Console.WriteLine("Operación exitosa. El resultado es: " + resultado);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error: " + e.Message);
                Console.WriteLine("La operación no pudo completarse debido a la división por cero.");
            }
            finally
            {
                Console.WriteLine("La operación ha terminado.");
            }
        }

        public int Dividiendo (int ValorA ,int ValorB)
        {
            try
            {
            int resultado = ValorA / ValorB;
               return resultado;

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine ( "error: " + e.Message);
                Console.WriteLine("¡Solo Chuck Norris divide por cero!");
                return -1;


            }
            finally 
            {
                Console.WriteLine("La operacion termino");
             }

        }
    }
}
