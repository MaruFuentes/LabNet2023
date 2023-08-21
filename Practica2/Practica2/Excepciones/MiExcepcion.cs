using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Excepciones
{
    public class MiExcepcion:Exception 
    {
        public MiExcepcion(string message) : base(message)
        {

        }
    }
}
