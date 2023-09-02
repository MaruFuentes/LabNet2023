using Practica3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3.Logic
{
    public class BaseLogic

    {
        protected readonly NothwindContext context;

        public BaseLogic()
        {
            context = new NothwindContext();    
        }
    }
}
