using EF.Data1;
using EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.logic
{
    public class ProductsLogic : BaseLogic,IABMLogic<Products>
    {
        public void add(Products newRegion)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Products> GetAll()
        {
            return context.Products.ToList(); 
        }

        public void Update(Products region)
        {
            throw new NotImplementedException();
        }
    }
}
