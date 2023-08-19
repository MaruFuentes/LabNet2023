using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO
{
    public class Taxi : TransportePublico
    {
        public Taxi(int pasajeros) : base(pasajeros)
        {
        }

        public override string Avanzar()
        {
            return string.Format("el taxi esta avanzando con {0} pasajeros", pasajeros);

        }

        public override string Detenerse()
        {
            return $"el taxi se detuvo y se bajaron  los {pasajeros} pasajeros ";
        }
    }
}
