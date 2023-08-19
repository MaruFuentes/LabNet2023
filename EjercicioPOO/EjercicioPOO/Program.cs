using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            LogicTransporte logicTransporte = new LogicTransporte();
            int seleccion;
            do
            {
                Console.WriteLine("Seleccione una opción");
                Console.WriteLine("opcion 1 - Cargar Taxis");
                Console.WriteLine("opcion 2 - Cargar Omnibus");
                Console.WriteLine("opcion 3 - Mostrar transporte");
                Console.WriteLine("0 - Salir");
                string entrada = Console.ReadLine();
                if (int.TryParse(entrada, out seleccion))
                {
                    switch (seleccion)
                    {

                        case 1:
                            if (!logicTransporte.TaxiCompleto)
                            {
                                logicTransporte.CargarTaxis();
                            }
                            else
                            {
                                Console.WriteLine("Se alcanzo el maximo de taxis");
                            }
                            break;
                        case 2:
                            if (!logicTransporte.Omnibuscompletos)
                            {
                                logicTransporte.CargarOmbibus();
                            }
                            else
                            {
                                Console.WriteLine("Se alcanzo el maximo de Omnibus");
                            }

                            break;
                        case 3:
                           
                                foreach (TransportePublico item in logicTransporte.GettransportePublicos())
                                {
                               
                                     Console.WriteLine(item.Avanzar());
                                    Console.WriteLine(item.Detenerse());
                                }
                            
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Ingresaste una opcion no valida o un caracter incorrecto intenta nuevamenta");
                    seleccion = -1;
                }

            } while (seleccion != 0);


            Console.WriteLine("Gracias! precione una tecla cualquiera para cerrar");
            Console.ReadKey();


           
        }

       
    }
}
