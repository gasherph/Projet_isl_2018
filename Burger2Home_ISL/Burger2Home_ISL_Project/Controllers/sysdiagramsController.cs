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
    builder.EntitySet<sysdiagrams>("sysdiagrams");
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class sysdiagramsController : ODataController
    {
        private Burger2Home db = new Burger2Home();

        // GET: odata/sysdiagrams
        [EnableQuery]
        public IQueryable<sysdiagrams> Getsysdiagrams()
        {
            return db.sysdiagrams;
        }

        // GET: odata/sysdiagrams(5)
        [EnableQuery]
        public SingleResult<sysdiagrams> Getsysdiagrams([FromODataUri] int key)
        {
            return SingleResult.Create(db.sysdiagrams.Where(sysdiagrams => sysdiagrams.diagram_id == key));
        }

        // PUT: odata/sysdiagrams(5)
        public IHttpActionResult Put([FromODataUri] int key, Delta<sysdiagrams> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            sysdiagrams sysdiagrams = db.sysdiagrams.Find(key);
            if (sysdiagrams == null)
            {
                return NotFound();
            }

            patch.Put(sysdiagrams);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!sysdiagramsExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(sysdiagrams);
        }

        // POST: odata/sysdiagrams
        public IHttpActionResult Post(sysdiagrams sysdiagrams)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.sysdiagrams.Add(sysdiagrams);
            db.SaveChanges();

            return Created(sysdiagrams);
        }

        // PATCH: odata/sysdiagrams(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<sysdiagrams> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            sysdiagrams sysdiagrams = db.sysdiagrams.Find(key);
            if (sysdiagrams == null)
            {
                return NotFound();
            }

            patch.Patch(sysdiagrams);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!sysdiagramsExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(sysdiagrams);
        }

        // DELETE: odata/sysdiagrams(5)
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            sysdiagrams sysdiagrams = db.sysdiagrams.Find(key);
            if (sysdiagrams == null)
            {
                return NotFound();
            }

            db.sysdiagrams.Remove(sysdiagrams);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool sysdiagramsExists(int key)
        {
            return db.sysdiagrams.Count(e => e.diagram_id == key) > 0;
        }
    }
}
