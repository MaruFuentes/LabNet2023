using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO
{
    public class LogicTransporte
    {



        private List<TransportePublico> transportePublicos = new List<TransportePublico>();
        public bool TaxiCompleto = false;
        public bool Omnibuscompletos = false;
        public void CargarTaxis()
        {

            for (int i = 0; i <= 4; i++)
            {
                int cantidad;
                bool isOk = false;
                do
                {
                    Console.WriteLine("Taxi n°" + (i + 1) + " ¿Cuantos pasajeros suben?");
                    string entrada = Console.ReadLine();
                    if (int.TryParse(entrada, out cantidad))
                    {
                        if (cantidad > 4 || cantidad < 0)
                        {
                            Console.WriteLine("Solo pueden entrar hasta 4 pasajeros");
                        }
                        else
                        {
                            TransportePublico transp = new Taxi(cantidad);
                            transportePublicos.Add(transp);
                            isOk = true;
                        }

                    }
                    else
                    {
                        Console.WriteLine("No ingresaste un caracter valido");
                    }


                } while (isOk == false);
                
            }
            TaxiCompleto = true;
        }


        public void CargarOmbibus()
        {

            for (int i = 0; i <= 4; i++)
            {
                int cantidad;
                bool isOk = false;
                do
                {
                    Console.WriteLine("Omnibus n°" + (i + 1) + " ¿Cuantos pasajeros suben?");
                    string entrada = Console.ReadLine();
                    if (int.TryParse(entrada, out cantidad))
                    {
                        if (cantidad > 50 || cantidad < 0)
                        {
                            Console.WriteLine("Solo pueden entrar hasta 50 pasajeros");
                        }
                        else
                        {
                            TransportePublico transp = new Omnibus(cantidad);
                            transportePublicos.Add(transp);
                            isOk = true;
                        }

                    }
                    else
                    {
                        Console.WriteLine("No ingresaste un caracter valido");
                    }


                } while (isOk == false);
            }
            Omnibuscompletos = true;
            
        }


        public List<TransportePublico> GettransportePublicos()
        {
            return this.transportePublicos;
        }

    }




}

