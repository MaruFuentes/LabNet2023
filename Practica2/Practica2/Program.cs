using Practica2.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operaciones operaciones = new Operaciones();
            Logic logic = new Logic();
            try
            {
               
                Console.WriteLine("Punto numero 1");
                Console.Write("Ingrese un valor: ");
                int valor = Convert.ToInt32(Console.ReadLine());
               operaciones.DivisionConExcepcion(valor);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Ingrese un valor numérico válido.");
            } 
            
            try
            {
                Console.WriteLine("....................................");
                Console.WriteLine("Punto numero 2");
                Console.WriteLine("Ingrese un numero para el dividendo");
                int num1= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ingrese un numero para el divisor");
                int num2= Convert.ToInt32(Console.ReadLine());
                int resultado = operaciones.Dividiendo(num1 , num2);
               if (resultado != -1)
                {
                    Console.WriteLine("El resultado de la division es: " + resultado);
                }

            }
            catch (FormatException)
            {
            Console.WriteLine("¡Seguro Ingreso una letra o no ingreso nada!");
                
            }
            try
            {
                Console.WriteLine("....................................");
                Console.WriteLine("Punto numero 3");

                logic.DisparoDeExcepcion();
               
            }
            catch (OverflowException e)
            {
                Console.WriteLine("error excepcion capturada : " + e.Message);
                Console.WriteLine("el tipo de excepcion es: " + e.GetType().Name);
             
            }
            try
            {
                Console.WriteLine("....................................");
                Console.WriteLine("Punto 4");
                logic.DisparoMiExcepcion();

            }
            catch (MiExcepcion e)
            {

                Console.WriteLine("error de excepcion capturada : " + e.Message);
                Console.WriteLine("el tipo de excepcion es: " + e.GetType().Name);
            }



            Console.ReadKey();
        }

      
    }
}
    

