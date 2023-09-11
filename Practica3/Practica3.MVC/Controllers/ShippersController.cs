using Practica3.Entities;
using Practica3.Logic;
using Practica3.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;


namespace Practica3.MVC.Controllers
{
    public class ShippersController : Controller
    {
        ShippersLogic logic = new ShippersLogic();
        // GET: Shippers
        public ActionResult Index()
        {
          
            List<Entities.Shippers> shippers = logic.GetAll();
            List<ShippersView> shippersViews = shippers.Select(s => new ShippersView
            {
                Id = s.ShipperID,
                CompanyName = s.CompanyName,
            }).ToList();
            return View(shippersViews);
        }
        public ActionResult Insert() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(ShippersView shippersView)
        {
            try
            {
              Shippers shippersEntity = new Shippers { CompanyName = shippersView.CompanyName };
                logic.Add(shippersEntity);
                return RedirectToAction("Index");

            }
            catch (Exception ex) 
            {

                return RedirectToAction("Index", "Error");
            }

        }

        public ActionResult Delete(int Id)
        {
            try
            {
                logic.Delete(Id);
                return RedirectToAction("Index");
            }
            catch (ApplicationException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                return RedirectToAction("index");
            }
        }

        public ActionResult UpDate(int id)
        {
            Shippers shippers = logic.GetById(id);
            ShippersView shippersView = new ShippersView();
            shippersView.Id = shippers.ShipperID;
            shippersView.CompanyName = shippers.CompanyName;
            return View("Update",shippersView);

        }
        public ActionResult UpDateShipper(ShippersView shippers)
        {
            Shippers _shipers = new Shippers { CompanyName = shippers.CompanyName, ShipperID = shippers.Id };
            logic.Update(_shipers);
            return RedirectToAction("Index");
        }
    }
}