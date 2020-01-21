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
    builder.EntitySet<Groupe>("Groupes");
    builder.EntitySet<UserGroup>("UserGroup"); 
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class GroupesController : ODataController
    {
        private Burger2Home db = new Burger2Home();

        // GET: odata/Groupes
        [EnableQuery]
        public IQueryable<Groupe> GetGroupes()
        {
            return db.Groupe;
        }

        // GET: odata/Groupes(5)
        [EnableQuery]
        public SingleResult<Groupe> GetGroupe([FromODataUri] int key)
        {
            return SingleResult.Create(db.Groupe.Where(groupe => groupe.groupe_id == key));
        }

        // PUT: odata/Groupes(5)
        public IHttpActionResult Put([FromODataUri] int key, Delta<Groupe> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Groupe groupe = db.Groupe.Find(key);
            if (groupe == null)
            {
                return NotFound();
            }

            patch.Put(groupe);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GroupeExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(groupe);
        }

        // POST: odata/Groupes
        public IHttpActionResult Post(Groupe groupe)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Groupe.Add(groupe);
            db.SaveChanges();

            return Created(groupe);
        }

        // PATCH: odata/Groupes(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<Groupe> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Groupe groupe = db.Groupe.Find(key);
            if (groupe == null)
            {
                return NotFound();
            }

            patch.Patch(groupe);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GroupeExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(groupe);
        }

        // DELETE: odata/Groupes(5)
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            Groupe groupe = db.Groupe.Find(key);
            if (groupe == null)
            {
                return NotFound();
            }

            db.Groupe.Remove(groupe);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // GET: odata/Groupes(5)/UserGroup
        [EnableQuery]
        public IQueryable<UserGroup> GetUserGroup([FromODataUri] int key)
        {
            return db.Groupe.Where(m => m.groupe_id == key).SelectMany(m => m.UserGroup);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GroupeExists(int key)
        {
            return db.Groupe.Count(e => e.groupe_id == key) > 0;
        }
    }
}
