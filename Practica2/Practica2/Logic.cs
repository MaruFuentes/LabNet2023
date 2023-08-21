using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica2.Excepciones;

namespace Practica2
{
    public class Logic
    {
        public void DisparoDeExcepcion() 
        {
            throw new OverflowException();
        }
        public void DisparoMiExcepcion()
        {
            throw new MiExcepcion("Excepcion personalizada disparada");
        }

    }
}
