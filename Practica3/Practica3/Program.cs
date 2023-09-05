using Practica3.Entities;
using Practica3.Logic;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;

            do
            {
                try
                {

                    Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
                    Console.WriteLine("1 - Devolver objeto customer");
                    Console.WriteLine("2 - Devolver todos los productos sin stock ");
                    Console.WriteLine("3 - Devolver productos con stock y que valen mas de 3");
                    Console.WriteLine("4 - Devolver Customers de la region WA");
                    Console.WriteLine("5 - Devolver elemento con ID 789");
                    Console.WriteLine("6 - Devolver customers en mayusccula y minuscula");
                    Console.WriteLine("7 _ Devolver customers de region WA con Orders > a 1/1/1997 ");
                    Console.WriteLine("8 _ Devolver 3 primeros customer de region WA");
                    Console.WriteLine("9 _ Devolver lista de productos ordenados por nombre");
                    Console.WriteLine("10 _ Devolver lista de productos en stock ordenados de > a <  ");
                    Console.WriteLine("11 _ Devolver categorias asociadas a los productos  ");
                    Console.WriteLine("12 _ Devolver 1er elemento de una lista de productos");
                    Console.WriteLine("13 _ Devolver customer con la cantidad de ordenes asociadas ");
                    Console.WriteLine("Ingresa una Opcion");
                    opcion = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
                    switch (opcion)
                    {
                        case 1:
                            CustomersLogic customersLogic = new CustomersLogic();
                            Customers customers = customersLogic.GetFistCustomer();
                            Console.WriteLine("ID: " + customers.CustomerID);
                            Console.WriteLine("CompanyName: " + customers.CompanyName);
                            Console.WriteLine("CotactName: " + customers.ContactName);


                            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
                            break;

                        case 2:

                            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
                            ProductsLogic productsLogic = new ProductsLogic();
                            foreach (Products item in productsLogic.GetProductsSinStock())
                            {
                                Console.WriteLine("Nombre: " + item.ProductName + " stock: " + item.UnitsInStock);
                            }


                            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
                            break;

                        case 3:

                            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
                            productsLogic = new ProductsLogic();
                            foreach (Products item in productsLogic.GetProductsConStock())
                            {
                                Console.WriteLine("Nombre: " + item.ProductName + " stock: " + item.UnitsInStock + " Valor: " + item.UnitPrice);
                            }

                            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
                            break;

                        case 4:

                            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
                            customersLogic = new CustomersLogic();
                            foreach (Customers item in customersLogic.GetCustomersRegionWA())
                            {
                                Console.WriteLine("Nombre: " + item.CompanyName + " region : " + item.Region);
                            }

                            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
                            break;

                        case 5:
                            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
                            productsLogic = new ProductsLogic();
                            var elemento = productsLogic.getElement789();
                            Console.WriteLine(elemento);

                            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
                            break;

                        case 6:
                            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
                            customersLogic = new CustomersLogic();
                            var Listado = customersLogic.GetCustomersMayYMin();
                            foreach (Customers item in Listado)
                            {
                                Console.WriteLine(item.CompanyName.ToUpper());
                                Console.WriteLine(item.CompanyName.ToLower());
                            }
                            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
                            break;

                        case 7:
                            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
                            customersLogic = new CustomersLogic();
                            foreach (CustomerDTO item in customersLogic.CustomersOrders())
                            {
                                Console.WriteLine("Nombre: " + item.Customer.CompanyName + " Region: " + item.Customer.Region);
                                Console.WriteLine("Fecha: " + item.Order.OrderDate);
                                //foreach (Orders item1 in item.Orders)
                                //{
                                //    Console.WriteLine("Fecha: " + item1.OrderDate);
                                //}

                                Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
                            }
                            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
                            break;

                        case 8:
                            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
                            customersLogic = new CustomersLogic();
                            foreach (Customers item in customersLogic.FirstThreeRegionWA())
                            {
                                Console.WriteLine(" Id: " + item.CustomerID + " region " + item.Region);
                            }
                            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
                            break;


                        case 9:
                            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
                            productsLogic = new ProductsLogic();
                            foreach (Products item in productsLogic.GetProductOrdenadoNombre())
                            {
                                Console.WriteLine(item.ProductName);
                            }
                            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
                            break;

                        case 10:
                            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
                            productsLogic = new ProductsLogic();
                            foreach (Products item in productsLogic.GetProductosOrdenadoMayMen())
                            {
                                Console.WriteLine("Nombre: "+ item.ProductName + " Unidades en stock: "+item.UnitsInStock);
                            }
                            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
                            break;

                        case 11:
                            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");

                            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
                            break;

                        case 12:
                            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");

                            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
                            break;

                        case 13:
                            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");

                            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
                            break;


                        default:
                            break;
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("ingrese solamente numeros");
                }
                catch(ApplicationException Aex)
                {
                    Console.WriteLine(Aex.Message);
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("No se encuentra el elemento");
                }
                catch (Exception)
                {

                    throw;
                }

            } while (opcion!=0);



            Console.ReadLine();
        }
        }
    }

