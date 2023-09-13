using Practica3.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Practica3.Logic;
using Practica3.Entities;


namespace Practica3.API.Controllers
{
    public class ShippersController : ApiController
    {

        private readonly ShippersLogic _shippersLogic;

        public ShippersController()
        {
            _shippersLogic = new ShippersLogic();
        }

        // GET api/<controller>
        public IEnumerable<ShippersView> Get()
        {
          
            List<ShippersView> shippersViews = _shippersLogic.GetAll().Select(s => new ShippersView
            {
                Id = s.ShipperID,
                CompanyName = s.CompanyName,
            }).ToList();
            return shippersViews;
        }

        // GET api/<controller>/5
        public IHttpActionResult  Get(int id)
        {
     
            Shippers shippers = _shippersLogic.GetById(id);

            if (shippers == null)
            {
                return BadRequest("no exite el elemento");
            }
            ShippersView shippersView = new ShippersView
            {
                Id = shippers.ShipperID,
                CompanyName = shippers.CompanyName,
           
            };

            return Ok(shippersView);

        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody] ShippersView shippers)
        {
            try
            {
                Shippers _shippers = new Shippers
                {
                    CompanyName = shippers.CompanyName

                };
                _shippersLogic.Add(_shippers);
                return Ok("Operación exitosa");
            }
            catch (Exception ex)
            {
               
                return BadRequest("Error: " + ex.Message);
            }
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody] ShippersView value)
        {
            try
            {
                Shippers _shippers = new Shippers
                {
                    ShipperID = id,
                    CompanyName = value.CompanyName

                };
                _shippersLogic.Update(_shippers);
                return Ok("Operación exitosa");
            }
            catch (Exception ex)
            {

                return BadRequest("Error" +  ex.Message);
            }
        }

        // DELETE api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                _shippersLogic.Delete(id);
                return Ok("Operación exitosa");
            }
            catch (Exception  ex)
            {

              return  BadRequest("Error: " + ex.Message);
            }
        }
    }
}