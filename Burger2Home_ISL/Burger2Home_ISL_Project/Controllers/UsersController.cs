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
    builder.EntitySet<Users>("Users");
    builder.EntitySet<UserGroup>("UserGroup"); 
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class UsersController : ODataController
    {
        private Burger2Home db = new Burger2Home();

        // GET: odata/Users
        [EnableQuery]
        public IQueryable<Users> GetUsers()
        {
            return db.Users;
        }

        
        // GET: odata/Users(5)
        [EnableQuery]

        public SingleResult<Users> GetUsers([FromODataUri] int key)
        {
            return SingleResult.Create(db.Users.Where(users => users.user_id == key ));
        }
       

        //public SingleResult<Users> findByEMailAndPassword([FromODataUri]Users user)
        //{
        //    return SingleResult.Create(db.Users.Where(users => user.email == "@email" && user.password == "@password"));
        //    //return SingleResult.Create(db.Users.Where ((users => users.email == email) , (users => users.password == password)));         

        //}


        // PUT: odata/Users(5)
        public IHttpActionResult Put([FromODataUri] int key, Delta<Users> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Users users = db.Users.Find(key);
            if (users == null)
            {
                return NotFound();
            }

            patch.Put(users);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsersExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(users);
        }

        // POST: odata/Users
        public IHttpActionResult Post(Users users)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Users.Add(users);
            db.SaveChanges();

            return Created(users);
        }

        // PATCH: odata/Users(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<Users> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Users users = db.Users.Find(key);
            if (users == null)
            {
                return NotFound();
            }

            patch.Patch(users);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsersExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(users);
        }

        // DELETE: odata/Users(5)
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            Users users = db.Users.Find(key);
            if (users == null)
            {
                return NotFound();
            }

            db.Users.Remove(users);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // GET: odata/Users(5)/UserGroup
        [EnableQuery]
        public IQueryable<UserGroup> GetUserGroup([FromODataUri] int key)
        {
            return db.Users.Where(m => m.user_id == key).SelectMany(m => m.UserGroup);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UsersExists(int key)
        {
            return db.Users.Count(e => e.user_id == key) > 0;
        }
    }
}
