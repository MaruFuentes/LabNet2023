using Practica3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Practica3.Logic
{
    public class ProductsLogic: BaseLogic
    {
        public List<Products> GetProductsSinStock()
        {
            var query = from product in context.Products
                        where product.UnitsInStock == 0
                        select product;

            return query.ToList();
        }
        public List<Products> GetProductsConStock()
        {
            var query = context.Products.Where(p=> p.UnitsInStock > 0 && p.UnitPrice>3)
                .Select(p => p).ToList();
            return query;

        }

        public Products getElement789()
        {
            var query = from product in context.Products
                        where product.ProductID ==789
                        select product;
            var element = query.FirstOrDefault(); 

            if (element == null)
            {
                throw new ApplicationException("El Elemento 789 no existe");
            }

            return element;


        }

        public List<Products> GetProductOrdenadoNombre()

        {
        var query = from product in context.Products
                    orderby product.ProductName
                    select product;

                    return  query.ToList();
        }

        public List<Products> GetProductosOrdenadoMayMen()
        {
         var query = context.Products.Where(p =>  p.UnitsInStock > 0)
                .OrderByDescending(p =>p.UnitsInStock)
                .ToList();
            return query;
            
        }
    }
}
