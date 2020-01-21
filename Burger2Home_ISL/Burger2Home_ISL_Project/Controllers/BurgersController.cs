using System;
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
    builder.EntitySet<Burger>("Burgers");
    builder.EntitySet<Ingredient>("Ingredient"); 
    builder.EntitySet<Orders>("Orders"); 
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class BurgersController : ODataController
    {
        private Burger2Home db = new Burger2Home();

        // GET: odata/Burgers
        [EnableQuery]
        public IQueryable<Burger> GetBurgers()
        {
            return db.Burger;
        }

        // GET: odata/Burgers(5)
        [EnableQuery]
        public SingleResult<Burger> GetBurger([FromODataUri] int key)
        {
            return SingleResult.Create(db.Burger.Where(burger => burger.burger_Id == key));
        }

        // PUT: odata/Burgers(5)
        public IHttpActionResult Put([FromODataUri] int key, Delta<Burger> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Burger burger = db.Burger.Find(key);
            if (burger == null)
            {
                return NotFound();
            }

            patch.Put(burger);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BurgerExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(burger);
        }

        // POST: odata/Burgers
        public IHttpActionResult Post(Burger burger)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Burger.Add(burger);
            db.SaveChanges();

            return Created(burger);
        }

        // PATCH: odata/Burgers(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<Burger> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Burger burger = db.Burger.Find(key);
            if (burger == null)
            {
                return NotFound();
            }

            patch.Patch(burger);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BurgerExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(burger);
        }

        // DELETE: odata/Burgers(5)
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            Burger burger = db.Burger.Find(key);
            if (burger == null)
            {
                return NotFound();
            }

            db.Burger.Remove(burger);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // GET: odata/Burgers(5)/Ingredient
        [EnableQuery]
        public SingleResult<Ingredient> GetIngredient([FromODataUri] int key)
        {
            return SingleResult.Create(db.Burger.Where(m => m.burger_Id == key).Select(m => m.Ingredient));
        }

        // GET: odata/Burgers(5)/Orders
        [EnableQuery]
        public IQueryable<Orders> GetOrders([FromODataUri] int key)
        {
            return db.Burger.Where(m => m.burger_Id == key).SelectMany(m => m.Orders);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BurgerExists(int key)
        {
            return db.Burger.Count(e => e.burger_Id == key) > 0;
        }
    }
}
