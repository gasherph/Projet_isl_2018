﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.OData;
using System.Web.Http.OData.Routing;
using Burger2Home_ISL_Project.Models;

namespace Burger2Home_ISL_Project.Controllers
{
    /*
    The WebApiConfig class may require additional changes to add a route for this controller. Merge these statements into the Register method of the WebApiConfig class as applicable. Note that OData URLs are case sensitive.

    using System.Web.Http.OData.Builder;
    using System.Web.Http.OData.Extensions;
    using Burger2Home_ISL_Project.Models;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<Orders>("Orders");
    builder.EntitySet<Burger>("Burger"); 
    builder.EntitySet<Customer>("Customer"); 
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class OrdersController : ODataController
    {
        private Burger2Home db = new Burger2Home();

        // GET: odata/Orders
        [EnableQuery]
        public IQueryable<Orders> GetOrders()
        {
            return db.Orders;
        }

        // GET: odata/Orders(5)
        [EnableQuery]
        public SingleResult<Orders> GetOrders([FromODataUri] int key)
        {
            return SingleResult.Create(db.Orders.Where(orders => orders.order_id == key));
        }

        // PUT: odata/Orders(5)
        public IHttpActionResult Put([FromODataUri] int key, Delta<Orders> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Orders orders = db.Orders.Find(key);
            if (orders == null)
            {
                return NotFound();
            }

            patch.Put(orders);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrdersExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(orders);
        }

        // POST: odata/Orders
        public IHttpActionResult Post(Orders orders)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Orders.Add(orders);
            db.SaveChanges();

            return Created(orders);
        }

        // PATCH: odata/Orders(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<Orders> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Orders orders = db.Orders.Find(key);
            if (orders == null)
            {
                return NotFound();
            }

            patch.Patch(orders);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrdersExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(orders);
        }

        // DELETE: odata/Orders(5)
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            Orders orders = db.Orders.Find(key);
            if (orders == null)
            {
                return NotFound();
            }

            db.Orders.Remove(orders);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // GET: odata/Orders(5)/Burger
        [EnableQuery]
        public SingleResult<Burger> GetBurger([FromODataUri] int key)
        {
            return SingleResult.Create(db.Orders.Where(m => m.order_id == key).Select(m => m.Burger));
        }

        // GET: odata/Orders(5)/Customer
        [EnableQuery]
        public SingleResult<Customer> GetCustomer([FromODataUri] int key)
        {
            return SingleResult.Create(db.Orders.Where(m => m.order_id == key).Select(m => m.Customer));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OrdersExists(int key)
        {
            return db.Orders.Count(e => e.order_id == key) > 0;
        }
    }
}
