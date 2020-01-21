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
    builder.EntitySet<Allergene>("Allergenes");
    builder.EntitySet<Ingredient>("Ingredient"); 
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class AllergenesController : ODataController
    {
        private Burger2Home db = new Burger2Home();

        // GET: odata/Allergenes
        [EnableQuery]
        public IQueryable<Allergene> GetAllergenes()
        {
            return db.Allergene;
        }

        // GET: odata/Allergenes(5)
        [EnableQuery]
        public SingleResult<Allergene> GetAllergene([FromODataUri] int key)
        {
            return SingleResult.Create(db.Allergene.Where(allergene => allergene.allergene_id == key));
        }

        // PUT: odata/Allergenes(5)
        public IHttpActionResult Put([FromODataUri] int key, Delta<Allergene> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Allergene allergene = db.Allergene.Find(key);
            if (allergene == null)
            {
                return NotFound();
            }

            patch.Put(allergene);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AllergeneExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(allergene);
        }

        // POST: odata/Allergenes
        public IHttpActionResult Post(Allergene allergene)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Allergene.Add(allergene);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (AllergeneExists(allergene.allergene_id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return Created(allergene);
        }

        // PATCH: odata/Allergenes(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<Allergene> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Allergene allergene = db.Allergene.Find(key);
            if (allergene == null)
            {
                return NotFound();
            }

            patch.Patch(allergene);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AllergeneExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(allergene);
        }

        // DELETE: odata/Allergenes(5)
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            Allergene allergene = db.Allergene.Find(key);
            if (allergene == null)
            {
                return NotFound();
            }

            db.Allergene.Remove(allergene);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // GET: odata/Allergenes(5)/Ingredient
        [EnableQuery]
        public IQueryable<Ingredient> GetIngredient([FromODataUri] int key)
        {
            return db.Allergene.Where(m => m.allergene_id == key).SelectMany(m => m.Ingredient);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AllergeneExists(int key)
        {
            return db.Allergene.Count(e => e.allergene_id == key) > 0;
        }
    }
}
