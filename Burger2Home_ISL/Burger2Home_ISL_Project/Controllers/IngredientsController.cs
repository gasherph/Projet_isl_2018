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
    builder.EntitySet<Ingredient>("Ingredients");
    builder.EntitySet<Allergene>("Allergene"); 
    builder.EntitySet<Burger>("Burger"); 
    builder.EntitySet<Categorie>("Categorie"); 
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class IngredientsController : ODataController
    {
        private Burger2Home db = new Burger2Home();

        // GET: odata/Ingredients
        [EnableQuery]
        public IQueryable<Ingredient> GetIngredients()
        {
            return db.Ingredient;
        }

        // GET: odata/Ingredients(5)
        [EnableQuery]
        public SingleResult<Ingredient> GetIngredient([FromODataUri] int key)
        {
            return SingleResult.Create(db.Ingredient.Where(ingredient => ingredient.ingredient_id == key));
        }

        // PUT: odata/Ingredients(5)
        public IHttpActionResult Put([FromODataUri] int key, Delta<Ingredient> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Ingredient ingredient = db.Ingredient.Find(key);
            if (ingredient == null)
            {
                return NotFound();
            }

            patch.Put(ingredient);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IngredientExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(ingredient);
        }

        // POST: odata/Ingredients
        public IHttpActionResult Post(Ingredient ingredient)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Ingredient.Add(ingredient);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (IngredientExists(ingredient.ingredient_id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return Created(ingredient);
        }

        // PATCH: odata/Ingredients(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<Ingredient> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Ingredient ingredient = db.Ingredient.Find(key);
            if (ingredient == null)
            {
                return NotFound();
            }

            patch.Patch(ingredient);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IngredientExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(ingredient);
        }

        // DELETE: odata/Ingredients(5)
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            Ingredient ingredient = db.Ingredient.Find(key);
            if (ingredient == null)
            {
                return NotFound();
            }

            db.Ingredient.Remove(ingredient);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // GET: odata/Ingredients(5)/Allergene
        [EnableQuery]
        public SingleResult<Allergene> GetAllergene([FromODataUri] int key)
        {
            return SingleResult.Create(db.Ingredient.Where(m => m.ingredient_id == key).Select(m => m.Allergene));
        }

        // GET: odata/Ingredients(5)/Burger
        [EnableQuery]
        public IQueryable<Burger> GetBurger([FromODataUri] int key)
        {
            return db.Ingredient.Where(m => m.ingredient_id == key).SelectMany(m => m.Burger);
        }

        // GET: odata/Ingredients(5)/Categorie
        [EnableQuery]
        public SingleResult<Categorie> GetCategorie([FromODataUri] int key)
        {
            return SingleResult.Create(db.Ingredient.Where(m => m.ingredient_id == key).Select(m => m.Categorie));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool IngredientExists(int key)
        {
            return db.Ingredient.Count(e => e.ingredient_id == key) > 0;
        }
    }
}
