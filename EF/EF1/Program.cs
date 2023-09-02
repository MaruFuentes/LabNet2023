
using EF.Entities;
using EF.logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace EF1
{
     class Program
    {
        static void Main(string[] args)
        {
            //ProductsLogic productsLogic= new ProductsLogic ();


            //foreach (Products product in productsLogic.GetAll())
            //{
               // Console.WriteLine($"{product.ProductName} - {product.UnitPrice}");
                
           // }

        RegionLogic regionLogic = new RegionLogic();

            foreach (var item in regionLogic.GetAll())
            {
                Console.WriteLine($"{item.RegionID} - {item.RegionDescription}");
                
            }

            //regionLogic.add(new Region
            //{
            //    RegionID = 10,
            //    RegionDescription = "sarasa"
            //});

            //foreach (var item in regionLogic.GetAll())
            //{
            //    Console.WriteLine($"{item.RegionID} - {item.RegionDescription}");

            //}

            Console.WriteLine();

            //regionLogic.Delete(10);

            regionLogic.Update(new Region
            {
                RegionDescription = "nueva descripcion",
                RegionID = 10,
            });



            Console.WriteLine();

            foreach (var item in regionLogic.GetAll())
            {
                Console.WriteLine($"{item.RegionID} - {item.RegionDescription}");

            }





            Console.ReadLine();
        }
    }
}
