using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3.Entities
{
    public class CustomerDTO
    {
        public Customers Customer { get;set; }
        public Orders Order { get;set; }
    }
}
