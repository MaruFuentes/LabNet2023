using Practica3.Data;
using Practica3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3.Logic
{
    public class SuppliersLogic:BaseLogic
    {
   

        public List<Suppliers> GettAll()
        {
            return context.Suppliers.ToList();
        }

    }
}
