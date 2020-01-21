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
    builder.EntitySet<Categorie>("Categories");
    builder.EntitySet<Ingredient>("Ingredient"); 
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class CategoriesController : ODataController
    {
        //private Burger2HomeEntities db = new Burger2HomeEntities();

        private Burger2Home db = new Burger2Home();

        // GET: odata/Categories
        [EnableQuery]
        public IQueryable<Categorie> GetCategories()
        {
            return db.Categorie;
        }

        // GET: odata/Categories(5)
        [EnableQuery]
        public SingleResult<Categorie> GetCategorie([FromODataUri] int key)
        {
            return SingleResult.Create(db.Categorie.Where(categorie => categorie.categorie_id == key));
        }

        // PUT: odata/Categories(5)
        public IHttpActionResult Put([FromODataUri] int key, Delta<Categorie> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Categorie categorie = db.Categorie.Find(key);
            if (categorie == null)
            {
                return NotFound();
            }

            patch.Put(categorie);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategorieExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(categorie);
        }

        // POST: odata/Categories
        public IHttpActionResult Post(Categorie categorie)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Categorie.Add(categorie);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (CategorieExists(categorie.categorie_id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return Created(categorie);
        }

        // PATCH: odata/Categories(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<Categorie> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Categorie categorie = db.Categorie.Find(key);
            if (categorie == null)
            {
                return NotFound();
            }

            patch.Patch(categorie);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategorieExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(categorie);
        }

        // DELETE: odata/Categories(5)
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            Categorie categorie = db.Categorie.Find(key);
            if (categorie == null)
            {
                return NotFound();
            }

            db.Categorie.Remove(categorie);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // GET: odata/Categories(5)/Ingredient
        [EnableQuery]
        public IQueryable<Ingredient> GetIngredient([FromODataUri] int key)
        {
            return db.Categorie.Where(m => m.categorie_id == key).SelectMany(m => m.Ingredient);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CategorieExists(int key)
        {
            return db.Categorie.Count(e => e.categorie_id == key) > 0;
        }
    }
}
