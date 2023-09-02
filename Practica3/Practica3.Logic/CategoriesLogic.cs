using Practica3.Data;
using Practica3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3.Logic
{
    public class CategoriesLogic:BaseLogic
    {
    
        public List<Categories> GetAll()
        {
            return context.Categories.ToList();
        }
    }
}
