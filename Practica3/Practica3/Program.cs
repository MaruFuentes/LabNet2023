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
                    Console.WriteLine("1 - Listar todos los Shippers");
                    Console.WriteLine("2 - Listar todos los Categories");
                    Console.WriteLine("3 - Agregar un nuevo Shippers");
                    Console.WriteLine("4 - Actualizar un nuevo Shippers");
                    Console.WriteLine("5 - Eliminar");
                    Console.WriteLine("0 - Salir");
                    Console.WriteLine("Ingresa una Opcion");
                    opcion = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
                    switch (opcion)
                    {
                        case 1:
                            ShippersLogic shippersLogic = new ShippersLogic();

                            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
                            foreach (Shippers shippers in shippersLogic.GetAll())

                            {
                                Console.WriteLine($"{shippers.ShipperID} _ {shippers.CompanyName}");
                            }

                            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
                            break;

                        case 2:

                            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
                            CategoriesLogic categoriesLogic = new CategoriesLogic();

                            foreach (Categories categories in categoriesLogic.GetAll())
                            {
                                Console.WriteLine($"{categories.CategoryName} - {categories.Description}");

                            }

                            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
                            break;

                        case 3:

                            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
                            shippersLogic = new ShippersLogic();
                            Console.WriteLine("Ingrese nombre del conductor");
                            string nombre = Console.ReadLine();
                            shippersLogic.Add(new Shippers
                            {
                                CompanyName = nombre
                            });

                            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");

                            foreach (var item in shippersLogic.GetAll())

                            {
                                Console.WriteLine($"{item.ShipperID} _ {item.CompanyName}");
                            }

                            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
                            break;

                        case 4:

                            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
                            shippersLogic = new ShippersLogic();
                            Console.WriteLine("Ingrese el ID del elemento a modificar");
                            int ID = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese nombre del conductor");
                            string nombreNuevo = Console.ReadLine();
                            shippersLogic.Update(new Shippers
                            {
                                CompanyName = nombreNuevo,
                                ShipperID = ID
                            });


                            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");


                            foreach (var item in shippersLogic.GetAll())

                            {
                                Console.WriteLine($"{item.ShipperID} _ {item.CompanyName}");
                            }

                            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
                            break;

                        case 5:
                            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
                            shippersLogic = new ShippersLogic();
                            foreach (var item in shippersLogic.GetAll())

                            {
                                Console.WriteLine($"{item.ShipperID} _ {item.CompanyName}");
                            }
                            Console.WriteLine("Ingrese el ID del elemento a eliminar");
                            ID = Convert.ToInt32(Console.ReadLine());
                            shippersLogic.Delete(ID);
                            foreach (var item in shippersLogic.GetAll())

                            {
                                Console.WriteLine($"{item.ShipperID} _ {item.CompanyName}");
                            }

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

