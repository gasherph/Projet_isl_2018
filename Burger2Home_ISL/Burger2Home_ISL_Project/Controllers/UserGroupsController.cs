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
    builder.EntitySet<UserGroup>("UserGroups");
    builder.EntitySet<Groupe>("Groupe"); 
    builder.EntitySet<Users>("Users"); 
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class UserGroupsController : ODataController
    {
        private Burger2Home db = new Burger2Home();

        // GET: odata/UserGroups
        [EnableQuery]
        public IQueryable<UserGroup> GetUserGroups()
        {
            return db.UserGroup;
        }

        // GET: odata/UserGroups(5)
        [EnableQuery]
        public SingleResult<UserGroup> GetUserGroup([FromODataUri] int key)
        {
            return SingleResult.Create(db.UserGroup.Where(userGroup => userGroup.userGroup_id == key));
        }

        // PUT: odata/UserGroups(5)
        public IHttpActionResult Put([FromODataUri] int key, Delta<UserGroup> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            UserGroup userGroup = db.UserGroup.Find(key);
            if (userGroup == null)
            {
                return NotFound();
            }

            patch.Put(userGroup);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserGroupExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(userGroup);
        }

        // POST: odata/UserGroups
        public IHttpActionResult Post(UserGroup userGroup)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.UserGroup.Add(userGroup);
            db.SaveChanges();

            return Created(userGroup);
        }

        // PATCH: odata/UserGroups(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<UserGroup> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            UserGroup userGroup = db.UserGroup.Find(key);
            if (userGroup == null)
            {
                return NotFound();
            }

            patch.Patch(userGroup);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserGroupExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(userGroup);
        }

        // DELETE: odata/UserGroups(5)
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            UserGroup userGroup = db.UserGroup.Find(key);
            if (userGroup == null)
            {
                return NotFound();
            }

            db.UserGroup.Remove(userGroup);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // GET: odata/UserGroups(5)/Groupe
        [EnableQuery]
        public SingleResult<Groupe> GetGroupe([FromODataUri] int key)
        {
            return SingleResult.Create(db.UserGroup.Where(m => m.userGroup_id == key).Select(m => m.Groupe));
        }

        // GET: odata/UserGroups(5)/Users
        [EnableQuery]
        public SingleResult<Users> GetUsers([FromODataUri] int key)
        {
            return SingleResult.Create(db.UserGroup.Where(m => m.userGroup_id == key).Select(m => m.Users));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UserGroupExists(int key)
        {
            return db.UserGroup.Count(e => e.userGroup_id == key) > 0;
        }
    }
}
