using Practica3.Data;
using Practica3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3.Logic
{
    public class CustomersLogic: BaseLogic
    {
        public Customers GetFistCustomer()
        {
            var query = context.Customers.First();
            return query;
        }

        public List<Customers> GetCustomersRegionWA()
        {
            var query = context.Customers.Where(c => c.Region == "WA")
                .Select(c => c).ToList();
            return query;
        }

        public List<Customers> GetCustomersMayYMin()
        {
            var query = context.Customers.ToList();
                
            return query;
        }

        public List<CustomerDTO> CustomersOrders()
        {
            DateTime fecha = new DateTime(1997, 1, 1);
            var query = (from customers in context.Customers
                         join orders in context.Orders on customers.CustomerID equals orders.CustomerID
                         where customers.Region == "WA" && orders.OrderDate > fecha
                         select new CustomerDTO()
                         {
                             Customer = customers,
                             Order = orders

                         }).ToList();
            return query;

        }
        public List<Customers> FirstThreeRegionWA()
        {
        var query = context.Customers.Where(c => c.Region== "WA")
                .Select(c => c).Take(3).ToList();
            return query;
        }
      
    }
}
