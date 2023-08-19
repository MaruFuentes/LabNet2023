using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO
{
    public abstract class TransportePublico
    {
        public TransportePublico(int pasajeros) { 
            this.pasajeros = pasajeros;
        }
       protected int pasajeros;

        public int GetPasajeros() { return this.pasajeros; }
        public abstract string Avanzar();
        public abstract string Detenerse();

    }
}
