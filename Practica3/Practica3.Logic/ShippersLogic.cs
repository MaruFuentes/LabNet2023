using Practica3.Data;
using Practica3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3.Logic
{
    public class ShippersLogic:BaseLogic,IABMLogic<Shippers>
    {
    
        public List<Shippers> GetAll()

        {
            return context.Shippers.ToList();
        }

        public void Add(Shippers newshippers)
        {
            context.Shippers.Add(newshippers);
            context.SaveChanges();
        }


        public void Delete(int id)
        {
           
            var shippersAEliminar = context.Shippers.Find(id);
            if (shippersAEliminar.Orders.Count > 0) { throw new ApplicationException("El elemento seleccionado no se puede eliminar por tener ordenes relacionadas"); }
            context.Shippers.Remove(shippersAEliminar);

            context.SaveChanges();
        }

        public Shippers GetById(int id) {
            var shiperResult = context.Shippers.Find(id) as Shippers;
            return shiperResult;
        }

        public void Update(Shippers shippers)
        {

                var shippersUpdate = context.Shippers.Find(shippers.ShipperID);
                if (shippersUpdate != null)
                {

                    shippersUpdate.CompanyName = shippers.CompanyName;
                    shippersUpdate.Phone = shippers.Phone;
                    context.SaveChanges();
                }
                else
                {
                    throw new ApplicationException($"No se encontró un Shipper con ID {shippers.ShipperID}");
                }
            
         
        }
    }

}
